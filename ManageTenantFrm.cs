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
    public partial class ManageTenantFrm : Form
    {
        public ManageTenantFrm()
        {
            InitializeComponent();
        }

        private void loadTenant()
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "Select \r\n\t" +
                    "e1.Employee_id as ID,\r\n\t" +
                    "e1.FirstName + ' ' + e1.LastName as Name,\r\n\t" +
                    "e1.userName,\r\n\t" +
                    "e1.Role," +
                    "e1.password\r\n\t" +
                    "from Employee_acc as e1";

                SqlCommand cmd = new SqlCommand(query, connect);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Create a DataTable to store the retrieved data
                    DataTable dt = new DataTable();

                    // Load all data from the reader into the DataTable
                    dt.Load(reader);

                    // Assuming dgTenant has appropriate columns defined
                    dgTenant.DataSource = dt;
                }
            }
        }


        private void ManageTenantFrm_Load(object sender, EventArgs e)
        {
            loadTenant();
        }

        private void dgTenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgTenant.Rows[e.RowIndex];

                selectedRow.Selected = true;

                txtID.Text = selectedRow.Cells["Name"].Value.ToString();


            }
        }
    }
}
