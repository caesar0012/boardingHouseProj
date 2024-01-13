using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class MaintenanceRequest : Form
    {
        public MaintenanceRequest()
        {
            InitializeComponent();
        }

        private void MaintenanceRequest_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Insert into Maintenance(staff_id, Details) values" +
                    "(@staff_id, @details)";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    cmd.Parameters.AddWithValue("@staff_id", frmLogin.staff_id);
                    cmd.Parameters.AddWithValue("@details", txtDescription.Text);

                    cmd.ExecuteNonQuery();

                }
            
            }
            this.Dispose();
        }
        
    }
}
