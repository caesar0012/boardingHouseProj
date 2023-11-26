using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace boardingHouseProj
{
    public partial class acc_prac01 : Form
    {
        public acc_prac01()
        {
            InitializeComponent();
        }

            string imgFilePath = "";
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                using (SqlConnection connection = new SqlConnection(ConnectSql.connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO account (username, password, profile_picture) VALUES (@Username, @Password, @images)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Read the image data into a byte array
                        byte[] imageData = null;
                        if (imgFilePath != null && imgFilePath != "")
                        {
                            using (FileStream fileStream = new FileStream(imgFilePath, FileMode.Open, FileAccess.Read))
                            {
                                imageData = new byte[fileStream.Length];
                                fileStream.Read(imageData, 0, imageData.Length);
                            }
                        }

                        command.Parameters.AddWithValue("@images", imageData);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Success Upload");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            

            ofdProfile.Filter = "png files(*.png) | *.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (ofdProfile.ShowDialog() == DialogResult.OK) { 
            
                imgFilePath = ofdProfile.FileName.ToString();
                dpBox.ImageLocation = imgFilePath;
            
            }
        }


        private void UploadProfilePicture()
        {
            





        }
        //this opens the image from sql
        private void btnProfile_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();
                string query = "SELECT ProfilePic FROM Employee_Info WHERE Employee_id = @id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@id", 1);

                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            byte[] imageData = (byte[])read["ProfilePic"]; // Corrected column name
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                Image image = Image.FromStream(ms);
                                dpBox.Image = image;
                            }
                        }
                    }
                }
            }

        }
    }
}
