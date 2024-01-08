using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class TransactionFrm : Form
    {
        public TransactionFrm()
        {
            InitializeComponent();
        }

        private void TrasanctionFrm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "Select\r\n\t" +
                    "p1.Payment_id,\r\n\t" +
                    "t1.Tenant_id,\r\n\t" +
                    "t1.FirstName + ' ' + t1.LastName as Name,\r\n\t" +
                    "p1.Amount_paid," +
                    "p1.PaymentDate\r\n" +
                    "from Tenant as t1\r\n" +
                    "left join lease_tbl as l1\r\n" +
                    "on l1.Tenant_id = t1.Tenant_id\r\n" +
                    "left join Payment as p1\r\n" +
                    "on p1.Lease_id = l1.lease_id\r\n" +
                    "where p1.Payment_id is not null and p1.archive = 0";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) {

                            dgTransaction.Rows.Add(reader["Payment_id"], reader["Name"], reader["Amount_paid"], reader["PaymentDate"]);
                        
                        }

                        dgTransaction.AllowUserToAddRows = false;
                    }
                }
            }
        }

        private void dgTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >=0) {
                
                DataGridViewRow selectedRow = dgTransaction.Rows[e.RowIndex];

                selectedRow.Selected = true;

                if (dgTransaction.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    DialogResult result = MessageBox.Show("Do you want to open receipt " + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Check the user's choice
                    if (result == DialogResult.Yes)
                    {
                       string num1 = selectedRow.Cells["clmnID"].Value?.ToString();

                        ReceiptForm.numRow = int.Parse(num1);

                        ReceiptForm r1 = new ReceiptForm();
                        r1.ShowDialog();

                    }
                    else
                    {
                        return;
                    }
                }




            }
        }
    }
}
