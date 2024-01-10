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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace boardingHouseProj
{
    public partial class Create_Staff_Acc : Form
    {
        public Create_Staff_Acc()
        {
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;
            txtFirstName.MaxLength = 25;
            txtLastName.MaxLength = 25;
            txtUserName.MaxLength = 20;
            txtPassword.MaxLength = 25;
            txtConfirmPass.MaxLength = 25;
            txtAnswerQuestion.MaxLength = 25;

            

        }
        string imgFilePath = null;

        private void button1_Click(object sender, EventArgs e)
        {
            //this is the else if statement when the text box has problems

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {

                MessageBox.Show("Pls input firstname");

            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {

                MessageBox.Show("Pls input lastName");

            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {

                MessageBox.Show("Pls input password");

            } 
            else if (txtPassword.Text != txtConfirmPass.Text) {

                MessageBox.Show("Password does not match");

            }
            else if (string.IsNullOrEmpty(cmbQuestionPass.Text))
            {

                MessageBox.Show("Pls input Question for password");

            }
            else if (string.IsNullOrEmpty(cmbRole.Text))
            {

                MessageBox.Show("Pls input Role");

            }
            else if (string.IsNullOrEmpty(txtContact.Text))
            {

                MessageBox.Show("Pls input Contact");

            }
            else if (string.IsNullOrEmpty(txtAnswerQuestion.Text))
            {
                MessageBox.Show("Pls input answer for forgot question");
            }
            else if (string.IsNullOrEmpty(txtUserName.Text)) {
                MessageBox.Show("Pls Input username");
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectSql.connectionString))
                    {

                        connection.Open();
                        string firstname = txtFirstName.Text;
                        string lastname = txtLastName.Text;
                        long contact = long.Parse(txtContact.Text);
                        string username = txtUserName.Text;
                        string password = txtPassword.Text;
                        string forgotquestion = cmbQuestionPass.Text;
                        string forgotanswer = txtAnswerQuestion.Text;
                        string role = cmbRole.Text;

                        //this reads the image
                        byte[] imageData = null;
                        if (imgFilePath != null && imgFilePath != "")
                        {
                            using (FileStream fileStream = new FileStream(imgFilePath, FileMode.Open, FileAccess.Read))
                            {
                                imageData = new byte[fileStream.Length];
                                fileStream.Read(imageData, 0, imageData.Length);
                            }
                        }

                        string query = "insert into Staff_acc(FirstName, Lastname, ProfilePic, Contact, userName, password," +
                            "forgotQuestion, forgotAnswer, Role) values (@FirstName, @Lastname, @ProfilePic, @Contact, @userName, @password," +
                            "@forgotQuestion, @forgotAnswer, @Role)";

                        using (SqlCommand cmd = new SqlCommand(query, connection)) {

                            cmd.Parameters.AddWithValue("@FirstName", firstname);
                            cmd.Parameters.AddWithValue("@Lastname", lastname);
                            cmd.Parameters.AddWithValue("@ProfilePic", imageData);
                            cmd.Parameters.AddWithValue("@Contact", contact);
                            cmd.Parameters.AddWithValue("@userName", username);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@forgotQuestion", forgotquestion);
                            cmd.Parameters.AddWithValue("@forgotAnswer", forgotanswer);
                            cmd.Parameters.AddWithValue("@Role", role);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Insert Success");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try {

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
            if (e.KeyCode == Keys.Space) { 
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

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a number or a backspace.
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Check if the length of the text box is already 11.
            if (txtContact.Text.Length == 11)
            {
                e.Handled = true;
            }

            }
        void clear() { 
        
            txtUserName.Clear();
            txtAnswerQuestion.Clear();
            txtContact.Clear();
            txtConfirmPass.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();
            cmbQuestionPass.Text = "";
            cmbRole.Text = "";
            

        }

        private void btnClear(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
