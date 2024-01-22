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
    public partial class AddOnFrm : Form
    {
        public AddOnFrm()
        {
            InitializeComponent();
        }

        private void listTenant_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Select\r\n\t" +
                    "t1.Tenant_id,\r\n\t" +
                    "t1.FirstName + ' ' + t1.LastName as Name,\r\n\t" +
                    "l1.lease_id\r\n" +
                    "from Tenant as t1\r\n" +
                    "left join lease_tbl as l1\r\n" +
                    "on t1.Tenant_id = l1.Tenant_id\r\n" +
                    "where l1.lease_id is not null";

                SqlCommand cmd = new SqlCommand(query, connect);

                using (SqlDataReader reader = cmd.ExecuteReader()) {

                    while (reader.Read()) {

                        cmbTenantName.Items.Add(reader["Name"]);
                    
                    }
                    
                    cmbTenantName.Sorted = true;    
                
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) { 
            
                connect.Open();

                int leaseID = GetLeaseID();

                string query = "Insert into Addon(lease_id, staff_id, addOnAmount, AddonDetails) values" +
                    "(@lease_id, @staff_id, @addAmount, @addDetails)";

                using (SqlCommand cmd = new SqlCommand(query, connect)){

                    cmd.Parameters.AddWithValue("@lease_id", leaseID);
                    cmd.Parameters.AddWithValue("@staff_id", frmLogin.staff_id);
                    cmd.Parameters.AddWithValue("@addAmount", double.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@addDetails", txtDetails.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Submit Successfully.");
                }
            }
        }

        private int GetLeaseID()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    string query = "SELECT l1.Lease_id " +
                                   "FROM Tenant AS t1 " +
                                   "LEFT JOIN lease_tbl AS l1 ON t1.Tenant_id = l1.Tenant_id " +
                                   "WHERE l1.Lease_id IS NOT NULL AND " +
                                   "      t1.FirstName + ' ' + t1.Lastname = @name";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Use Parameters.AddWithValue cautiously, consider specifying SqlDbType
                        cmd.Parameters.AddWithValue("@name", cmbTenantName.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Use reader.IsDBNull to check for NULL values before calling GetInt32
                                return reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging purposes
                MessageBox.Show($"getLeaseID Error: {ex.Message}");
                return 0; // Return a default value or throw the exception based on your requirements
            }
        }


        private void cmbTenantName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtDetails.Text = getLeaseID().ToString();
        }
    }
}
