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
    public partial class Tenant_Request_frm : Form
    {
        public Tenant_Request_frm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Tenant_Request_frm_Load(object sender, EventArgs e)
        {
            loadList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)){

                connect.Open();

                string query = "Insert into";
            
            }
        }

        private void loadList() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Select FirstName + ' ' + LastName as Name \r\n" +
                    "from Tenant \r\nwhere Archive = 0\r\n" +
                    "ORDER by FirstName + ' ' + LastName ASC";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    using (SqlDataReader reader = cmd.ExecuteReader()) {

                        while (reader.Read()) {

                            cmbTenantName.Items.Add(reader["Name"]);

                        }
                    }
                }

                string query2 = "Select * from Room order by room_number asc";

                using (SqlCommand cmd = new SqlCommand(query2, connect)) {

                    using (SqlDataReader reader = cmd.ExecuteReader()) {

                        while (reader.Read()) {

                            cmbRoomNum.Items.Add(reader["Room_number"]);

                        }   
                    }
                }
            }
        }
    }
}
