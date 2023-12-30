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

                string query = "SELECT * FROM Tenant";

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
    }
}
