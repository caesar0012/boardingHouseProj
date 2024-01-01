using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class ViewFileTenant : Form
    {
        public ViewFileTenant()
        {
            InitializeComponent();
        }

        private void ViewFileTenant_Load(object sender, EventArgs e)
        {
            loadProfile();
        }

        private void loadProfile()
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "Select * from Tenant where Tenant_id = @ID";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@ID", EditTenantFrm.tenantID);

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] img = reader["Document_pic"] as byte[];

                            if (img == null)
                            {
                                dpFile.Image = null;
                            }
                            else
                            {
                                try
                                {
                                    using (MemoryStream ms = new MemoryStream(img))
                                    {
                                        dpFile.Image = Image.FromStream(ms);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error loading image: " + ex.Message);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing SQL query: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dpFile_Click(object sender, EventArgs e)
        {

        }
    }
}
