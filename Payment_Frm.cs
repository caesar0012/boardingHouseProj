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
    public partial class Payment_Frm : Form
    {
        public Payment_Frm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Payment_Frm_Load(object sender, EventArgs e)
        {
            FilterLoad("Select \r\n    " +
                "t1.Tenant_id, \r\n    " +
                "t1.FirstName + ' ' + t1.LastName as Name,\r\n    " +
                "t1.Gender,\r\n    " +
                "r1.Room_number,\r\n    " +
                "l1.assign_bed, l1.MonthlyPayment as Rent\r\n    " +
                "From Tenant as t1\r\n" +
                "left join lease_tbl as l1\r\n" +
                "on t1.Tenant_id = l1.Tenant_id\r\n" +
                "left join Room as r1\r\n" +
                "on l1.room_id = r1.Room_id\r\n" +
                "left join Payment as p1\r\n" +
                "on l1.Tenant_id = t1.Tenant_id");
        }

        private void FilterLoad(string query)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        DataTable dt = new DataTable();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Load the entire result set into the DataTable
                            dt.Load(reader);
                        }

                        dgPayment.DataSource = dt;
                    }
                }
            }
            catch {

                MessageBox.Show("Datagrid failed to load");
            
            }
        }

        private void dgPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgPayment.Rows[e.RowIndex];

            selectedRow.Selected = true;

       //     string tent_id = selectedRow.Cells["Tenant_id"].Value?.ToString();


        }

        private void dgPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >=0) {

                DataGridViewRow selectedRow = dgPayment.Rows[e.RowIndex];
                selectedRow.Selected = true;

                txtTenant_id.Text = selectedRow.Cells["Tenant_id"].Value?.ToString();
                txtTenantName.Text = selectedRow.Cells["Name"].Value?.ToString();
                txtPayment.Text = selectedRow.Cells["Rent"].Value?.ToString();


                /*txtDetailsAddon.Text = selectedRow.Cells["Rent"].Value?.ToString();
                txtAddOnsPrice.Text = selectedRow.Cells["Rent"].Value?.ToString();*/
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PaymentInsert();
        }


        private void PaymentInsert() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                int setLease = getLease_id();

                string query = "Insert into Payment(Employee_id, lease_id, Amount_paid, Payment_type, AddOnAmount, OutstandingBalance, AddOnDetails) values" +
                    "(@emp_id, @lease_id, @amount, @paymentType, @addOnAmount, @OutstandingBalance, @addOnDetail)";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@emp_id", frmLogin.employee_id);
                cmd.Parameters.AddWithValue("@lease_id", setLease);

                if (string.IsNullOrEmpty(txtPayment.Text)) {

                    cmd.Parameters.AddWithValue("@amount", 0);

                }
                else
                {

                    cmd.Parameters.AddWithValue("@amount", double.Parse(txtPayment.Text));

                }

                if (cmbPaymentType.SelectedIndex == -1)
                {
                    // No item selected, set the parameter value to NULL or another default value
                    cmd.Parameters.AddWithValue("@paymentType", DBNull.Value);
                }
                else
                {
                    // Item selected, use the selected text
                    cmd.Parameters.AddWithValue("@paymentType", cmbPaymentType.SelectedText);
                }

                if (string.IsNullOrEmpty(txtAddOnsPrice.Text))
                {
                    // No item selected, set the parameter value to NULL or another default value
                    cmd.Parameters.AddWithValue("@addOnAmount", DBNull.Value);
                }
                else
                {
                    // Item selected, use the selected text
                    cmd.Parameters.AddWithValue("@addOnAmount", double.Parse(txtAddOnsPrice.Text));
                }


                
                cmd.Parameters.AddWithValue("@OutstandingBalance", 0);
                cmd.Parameters.AddWithValue("@addOnDetail", txtDetailsAddon.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Success");
                
            
            }
        }

        private int getLease_id() { //The use of the method is for the insert rows of the Payment Table 

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Select \r\n\t" +
                    "l1.Lease_id\r\n" +
                    "from Tenant as t1\r\n" +
                    "left join lease_tbl as l1\r\n" +
                    "on t1.Tenant_id = l1.Tenant_id\r\n" +
                    "where l1.lease_id is not null and t1.archive = 0 and t1.Tenant_id = @tent_id";

                SqlCommand cmd = new SqlCommand(query, connect);

                if (int.TryParse(txtTenant_id.Text, out int num1))
                {
                    cmd.Parameters.AddWithValue("@tent_id", num1);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming Room_id is of type int, use GetInt32 instead of GetString
                            return reader.GetInt32(0); // Use index 0 for Room_id
                        }
                    }
                }
            }
            return 0;
        }
    }
}
