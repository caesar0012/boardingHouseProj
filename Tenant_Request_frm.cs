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

        private int tenant_id;

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

            if (string.IsNullOrEmpty(cmbTenantName.Text))
            {

                MessageBox.Show("Please Select a tenant");

            }
            else if (string.IsNullOrEmpty(txtDetails.Text))
            {

                MessageBox.Show("Please Input a details");

            }
            else {

                try {

                    using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                    {

                        connect.Open();

                        string query = "Insert into TenantRequest(Employee_id, Tenant_id, Details) values" +
                            "(@emp_id, @tenant_id, @details)";

                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {

                            cmd.Parameters.AddWithValue("@emp_id", frmLogin.employee_id);
                            cmd.Parameters.AddWithValue("@tenant_id", tenant_id);
                            cmd.Parameters.AddWithValue("@details", txtDetails.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Tenant Request Added");
                        }
                    }
                }
                catch(Exception ex) {

                    MessageBox.Show(ex.Message);
                
                }
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
            }
        }

        private void cmbTenantName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbTenantName.Text))
            {
                ///Do nothing

            }
            else {

                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    string query = "SELECT t1.Tenant_id, t1.FirstName + ' ' + t1.LastName as Name, r1.Room_number, l1.assign_bed\r\n" +
                                   "FROM Tenant AS t1\r\n" +
                                   "LEFT JOIN Room AS r1\r\n" +
                                   "ON t1.Tenant_id = r1.Room_id\r\n" +
                                   "LEFT JOIN lease_tbl AS l1\r\n" +
                                   "ON r1.Room_id = l1.lease_id WHERE t1.FirstName + ' ' + t1.LastName = @tenantID";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@tenantID", cmbTenantName.Text);

                        cmd.ExecuteNonQuery();

                        using (SqlDataReader reader = cmd.ExecuteReader()) {

                            while (reader.Read()) {

                                tenant_id = Convert.ToInt32(reader["Tenant_id"]);
                                txtRoomNum.Text = reader["Room_number"].ToString();
                                txtBed.Text = reader["assign_bed"].ToString();


                            }
                        
                        }
                    }
                }
            }
        }
    }
}
