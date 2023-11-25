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
    public partial class Create_Staff_Acc : Form
    {
        public Create_Staff_Acc()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }
        string imgFilePath = null;

        private void button1_Click(object sender, EventArgs e)
        {
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
                        connection.Close();
                        connection.Open();

                        string firstname = txtFirstName.Text;
                        string lastname = txtLastName.Text;
                        long contact = long.Parse(txtContact.Text);

                        //@ in the query mean it stores the declared string above

                        string query = "insert into Employee_Info(firstName, lastName, ProfilePic, Contact) " +
                        "values(@first, @last, @Profile ,@Contact)";
                        byte[] imageData = null;
                        if (imgFilePath != null && imgFilePath != "")
                        {
                            using (FileStream fileStream = new FileStream(imgFilePath, FileMode.Open, FileAccess.Read))
                            {
                                imageData = new byte[fileStream.Length];
                                fileStream.Read(imageData, 0, imageData.Length);
                            }
                        }
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@first", firstname);
                            cmd.Parameters.AddWithValue("@last", lastname);
                            cmd.Parameters.AddWithValue("@Contact", contact);
                            cmd.Parameters.AddWithValue("@Profile", imageData);

                            cmd.ExecuteNonQuery();

                        }
                        insert_acc();
                        connection.Close();
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

                OpenFileDialog ofdProfile = new OpenFileDialog();

                ofdProfile.Filter = "png files(*.png) | *.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

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

        void insert_acc()
        {
            try {

                string query_insert_acc = "insert into Employee_acc(userName, password, forgotQuestion, forgotAnswer, Role)values" +
                    "(@userName, @password, @forgotQuestion, @forgotAnswer, @Role)";

                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) { 
                    connect.Close();
                    connect.Open();

                    string username = txtUserName.Text;
                    string password = txtPassword.Text;
                    string forgotQuestion = cmbQuestionPass.Text;
                    string forgotAnswer = txtAnswerQuestion.Text;
                    string role = cmbRole.Text;
                    

                    using (SqlCommand cmd = new SqlCommand(query_insert_acc, connect)) {
                        cmd.Parameters.AddWithValue("@userName", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@forgotQuestion", forgotQuestion);
                        cmd.Parameters.AddWithValue("@forgotAnswer", forgotAnswer);
                        cmd.Parameters.AddWithValue("@Role", role);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success for account");

                    }
                    connect.Close();
                }
                
            }
            catch (Exception ex) {

                MessageBox.Show("Error: " + ex.Message);
            
            }
        
        
        
        }

    }
}
