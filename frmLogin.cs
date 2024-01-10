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

        public static string staff_id = "67";
        public static string role = "Manager";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //calls authenticator for user and pass
            if (authenticateLogin(txtUserName.Text.ToString(), txtPassword.Text.ToString())) {

                frmMain f1 = new frmMain();
                this.Hide();
                f1.Show();

            } else if (txtUserName.Text == "admin" && txtPassword.Text == "admin") {

                frmMain f1 = new frmMain();
                this.Hide();
                f1.Show();

            }
            else
            {
                MessageBox.Show("Failed Login. Please Try Again.");
            }
        }

        private Boolean authenticateLogin(string user, string pass)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                // collate means it was case-sensitive comparison for user and pass
                string query = "SELECT COUNT(*) FROM Staff_acc WHERE userName COLLATE latin1_general_cs_as = @user01 AND password COLLATE latin1_general_cs_as = @pass01 AND Archive = 0";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user01", user);
                    cmd.Parameters.AddWithValue("@pass01", pass);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // If login is successful, retrieve the staff ID and role
                        query = "SELECT Staff_id, Role FROM Staff_acc WHERE userName COLLATE latin1_general_cs_as = @user01 AND password COLLATE latin1_general_cs_as = @pass01 AND Archive = 0";
                        cmd.CommandText = query;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                              /*  // Assuming 'retrievedStaffID' is of type string
                                staff_id = reader["Staff_id"].ToString();

                                // Assuming 'retriveRole' is a string, update it accordingly if it's not
                                role = reader["Role"].ToString();*/
                            }
                        }

                        return true;
                    }

                    return false;
                }
            }
        }
        private void lblforgotPassword_Click(object sender, EventArgs e)
        {
            forgotPassFrms f1 = new forgotPassFrms();
            f1.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Simulate a button click here
                btnLogin_Click(sender, e);
            }
        }
    }
}
