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
    public partial class UserSettings : Form
    {

        public UserSettings()
        {
            InitializeComponent();
            txtContact.MaxLength = 11;
            txtUserName.MaxLength = 15;
            txtAnswerQuestion.MaxLength = 20;
        }

        string imgFilePath = null;

        string pass01;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPass.Text) {

                MessageBox.Show("Password does not match");

                return;
            }
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {

                connect.Open();

                string query = "Update Staff_acc set ProfilePic = @profile ,UserName = @user, Password = @pass, ForgotQuestion = @forgQuestion, ForgotAnswer = @forgotAnswer, Contact = @contact " +
                    "where staff_id = @staff_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

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

                    if (string.IsNullOrEmpty(txtPassword.Text))
                    {

                        cmd.Parameters.AddWithValue("@pass", pass01);

                    }
                    else {

                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                    }
                    cmd.Parameters.AddWithValue("@forgQuestion", cmbQuestionPass.Text);
                    cmd.Parameters.AddWithValue("@forgotAnswer", txtAnswerQuestion.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@staff_id", frmLogin.staff_id);

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

                string query = "Select * from Staff_acc where staff_id = @staff_id";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@staff_id", frmLogin.staff_id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()){
                        
                        byte[] img = reader["ProfilePic"] as byte[];

                        if (img == null)
                        {
                            
                        }
                        else
                        {
                            using (MemoryStream ms = new MemoryStream(img))
                            {
                                dpBox.Image = Image.FromStream(ms);
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
                    dpBox.ImageLocation = imgFilePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                e.SuppressKeyPress = true;

            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            txtUserName_KeyDown(sender, e);
        }

        private void txtConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            txtUserName_KeyDown(sender, e);
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            txtUserName_KeyDown(sender, e);
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {

                connect.Open();

                string query = "Select * from Staff_acc where staff_id = @staff_id";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("staff_id", frmLogin.staff_id); //change this for employee_id from login.cs

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        txtUserName.Text = reader["UserName"].ToString();
                      //  txtPassword.Text = reader["Password"].ToString();
                        cmbQuestionPass.Text = reader["ForgotQuestion"].ToString();
                        txtAnswerQuestion.Text = reader["ForgotAnswer"].ToString();
                        txtContact.Text = reader["Contact"].ToString();
                        pass01 = reader["password"].ToString();
                        txtLastName.Text = reader["FirstName"].ToString();
                        txtFirstName.Text = reader["Lastname"].ToString();

                    }
                }
            }
            loadProfile();
        }
    }
}

