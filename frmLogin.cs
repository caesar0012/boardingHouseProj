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

        public static int employee_id;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (authenticateLogin(txtUserName.Text.ToString(), txtPassword.Text.ToString())) {

                MessageBox.Show("Login Success");

                frmMain f1 = new frmMain();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Failed Login");
            }
            
        }

        private Boolean authenticateLogin(string user, string pass) {

            string username = txtUserName.Text;
            string password = txtPassword.Text;

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {
                connect.Close();
                connect.Open();

                string query = "Select count(*) from Employee_acc where userName = @user01 and password = @pass01 and Arhive = 0";
                
                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    cmd.Parameters.AddWithValue("@user01", username);
                    cmd.Parameters.AddWithValue("@pass01", password);

                    int count = (int)cmd.ExecuteScalar();

                    int retrievedEmployeeID = (int)cmd.ExecuteScalar();
                    employee_id = retrievedEmployeeID;

                    return count > 0;

            
                }
            }

        }

        private void lblforgotPassword_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
