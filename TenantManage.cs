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
    public partial class TenantManage : Form
    {
        public TenantManage()
        {
            InitializeComponent();
        }

        private void TenantManage_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Select \r\n    " +
                    "Tenant_id,\r\n    " +
                    "FirstName + ' ' + LastName as Name,\r\n    " +
                    "Gender,\r\n    " +
                    "Contact,\r\n    " +
                    "Emergency_name,\r\n    " +
                    "Emergency_contact, \r\n    " +
                    "Relationship,\r\n    " +
                    "School,\r\n    " +
                    "Address\r\n" +
                    "from Tenant";

                SqlCommand cmd = new SqlCommand(query, connect);

                using (SqlDataReader reader = cmd.ExecuteReader()) {

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgTenant.DataSource = dt;
                
                }
            
            
            }
        
        
        
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
