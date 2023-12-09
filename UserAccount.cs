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
    public partial class userAccount : Form
    {
        public userAccount()
        {
            InitializeComponent();
        }

        string imgFilePath = null;

        private void tbnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) { 
                
                connect.Open();

                string query = "Select * from Employee_acc where Employee_id = @emp_id";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("emp_id", txt_emp_id.Text);

                using (SqlDataReader reader = cmd.ExecuteReader()) {

                    while (reader.Read()) {

                        txtUserName.Text = reader["UserName"].ToString();
                        txtPassword.Text = reader["Password"].ToString();
                        cmbQuestionPass.Text = reader["ForgotQuestion"].ToString();
                        txtAnswerQuestion.Text = reader["ForgotAnswer"].ToString();
                        txtContact.Text = reader["Contact"].ToString();

                        txtLastName.Text = reader["FirstName"].ToString();
                        txtFirstName.Text = reader["Lastname"].ToString();

                    }
                }
            }
            loadProfile();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) { 
            
                connect.Open();

                string query = "Update Employee_acc set ProfilePic = @profile ,UserName = @user, Password = @pass, ForgotQuestion = @forgQuestion, ForgotAnswer = @forgotAnswer, Contact = @contact " +
                    "where Employee_id = @emp_id";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    byte[] imageData = null;
                    if (imgFilePath != null && imgFilePath != "")
                    {
                        using (FileStream fileStream = new FileStream(imgFilePath, FileMode.Open, FileAccess.Read))
                        {
                            imageData = new byte[fileStream.Length];
                            fileStream.Read(imageData, 0, imageData.Length);
                        }
                    }

                    cmd.Parameters.AddWithValue("@profile", imageData);
                    cmd.Parameters.AddWithValue("@user", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@forgQuestion", cmbQuestionPass.Text);
                    cmd.Parameters.AddWithValue("@forgotAnswer", txtAnswerQuestion.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@emp_id", txt_emp_id.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Update Success");
        }

        private void loadProfile()
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "Select * from Employee_acc where Employee_id = @emp_id";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@emp_id", txt_emp_id.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (int.TryParse(reader[0].ToString(), out int intNumValue))
                        {
                            txt_emp_id.Text = intNumValue.ToString();
                        }

                        byte[] img = reader["ProfilePic"] as byte[];

                        if (img == null)
                        {
                            dpProfile.Image = null;
                        }
                        else
                        {
                            using (MemoryStream ms = new MemoryStream(img))
                            {
                                dpProfile.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {

                //instance of Openfile dialog so I dont have to open filedialog on the designer
                OpenFileDialog ofdProfile = new OpenFileDialog();

                //this filters the file that profile picture can accept
                ofdProfile.Filter = "png files(*.png) | *.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

                //if the picture was selected it the filepath will be pass to the imgFilePath
                if (ofdProfile.ShowDialog() == DialogResult.OK)
                {

                    imgFilePath = ofdProfile.FileName.ToString();
                    dpProfile.ImageLocation = imgFilePath;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }

        }
    }
}
