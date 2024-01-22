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
    public partial class forgotPassFrms : Form
    {
        public forgotPassFrms()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogin l1 = new frmLogin();
            l1.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (authen(txtUserName.Text, cmbForgotPassQuest.Text, txtAnswer.Text))
            {

                MessageBox.Show("Login Successfully.");
                
                frmMain m1 = new frmMain();
                this.Hide();
                m1.ShowDialog();
                
            }
            else {

                MessageBox.Show("User not found.");
            
            }
        }

        private Boolean authen(string user, string forgotQ, string forgotAns)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM Staff_acc WHERE userName COLLATE latin1_general_cs_as = @user AND forgotQuestion = @forgotQ AND forgotAnswer = @forgotAns AND Archive = 0";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@forgotQ", forgotQ);
                    cmd.Parameters.AddWithValue("@forgotAns", forgotAns);

                    int count = (int)cmd.ExecuteScalar();

                    // Assuming you want to retrieve the staff_id if authentication is successful
                    if (count > 0)
                    {
                        query = "SELECT Staff_id FROM Staff_acc WHERE userName COLLATE latin1_general_cs_as = @user AND forgotQuestion = @forgotQ AND forgotAnswer = @forgotAns AND Archive = 0";
                        cmd.CommandText = query;

                        // Using ExecuteScalar to get a single value
                        object retrievedStaffID = cmd.ExecuteScalar();

                        // Check if retrievedStaffID is not null before converting to string
                        if (retrievedStaffID != null)
                        {
                            frmLogin.staff_id = retrievedStaffID.ToString();
                        }
                    }

                    return count > 0;
                }
            }
        }
    }
}
