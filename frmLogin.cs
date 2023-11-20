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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            using (SqlConnection connect  = new SqlConnection(ConnectSql.connectionString)) {
                try {
                    connect.Close();
                    connect.Open();

                    String query = @"select * from employee_account";
                    




                    connect.Close();
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                
                }
            
            
            }
        }
    }
}
