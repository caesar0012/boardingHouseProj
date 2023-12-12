using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Net.Configuration;

namespace boardingHouseProj
{
    public partial class room_tenant_add : Form
    {
        public room_tenant_add()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //this method loads the list to the form
        private void loadList()
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand("Select * from lease_tbl", connect);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();  // Create DataTable outside the loop

                    if (reader.HasRows)
                    {
                        dt.Load(reader);  // Load data into the DataTable once

                        dgAssignTenant.DataSource = dt;  // Set the DataTable as the DataSource for the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No Data");
                    }
                }
            }
        }



        private void txtTenant_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                MessageBox.Show("Hello piece of shit");
            
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Select t1.Tenant_id ,(t1.FirstName + ' ' + t1.LastName) as Name, Gender from Tenant as t1 ";

                SqlCommand cmd = new SqlCommand(query, connect);

                using (SqlDataReader reader = cmd.ExecuteReader()) {

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dgAssignTenant.DataSource = dt;
                }
            
            }
        }

        private void room_tenant_add_Load(object sender, EventArgs e)
        {
            loadList();
        }
    }
}
