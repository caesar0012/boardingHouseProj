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

        public static int staff_id = 61;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //calls authenticator for user and pass
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


            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {
                connect.Open();

                //collate mean it was case sensitive comparision for user and pass
                string query = "SELECT COUNT(*) FROM Staff_acc WHERE userName COLLATE latin1_general_cs_as = @user01 AND password COLLATE latin1_general_cs_as = @pass01 AND Archive = 0";


                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    cmd.Parameters.AddWithValue("@user01", user);
                    cmd.Parameters.AddWithValue("@pass01", pass);

                    int count = (int)cmd.ExecuteScalar();

                    int retrievedStaffID = (int)cmd.ExecuteScalar();
                //    staff_id = retrievedStaffID;

                    return count > 0;

            
                }
            }

        }

        private void lblforgotPassword_Click(object sender, EventArgs e)
        {
            forgotPassFrms f1 = new forgotPassFrms();
            f1.ShowDialog();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
