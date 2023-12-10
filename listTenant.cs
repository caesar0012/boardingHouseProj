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
    public partial class listTenant : Form
    {
        public listTenant()
        {
            InitializeComponent();
        }

        private void listTenant_Load(object sender, EventArgs e)
        {
            try {

                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                    connect.Open();

                    string query = "Select * from Tenant";

                    SqlCommand cmd = new SqlCommand(query, connect);

                    using (SqlDataReader reader = cmd.ExecuteReader()) {

                        while (reader.Read()) {

                            dgTenant.Rows.Add(reader["FirstName"]);
                        
                        
                        
                        }
                    
                    
                    }
                }


            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
