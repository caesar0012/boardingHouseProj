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
using static System.Net.Mime.MediaTypeNames;

namespace boardingHouseProj
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        string imgFilePath = "";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdCustomer = new OpenFileDialog();

            ofdCustomer.Filter = "png files(*.png) | *.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (ofdCustomer.ShowDialog() == DialogResult.OK)
            {

                imgFilePath = ofdCustomer.FileName.ToString();

                btnBrowse.Text = Path.GetFileName(imgFilePath);

                pb_tenantDoc.ImageLocation = imgFilePath;

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstname.Text))
            {

                MessageBox.Show("Pls input firstname");

            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {

                MessageBox.Show("Please input lastname");

            }
            else if (string.IsNullOrEmpty(txtContact.Text))
            {

                MessageBox.Show("Please input your own Contact Number");

            }
            else if (string.IsNullOrEmpty(txtEmergencyContact.Text))
            {

                MessageBox.Show("Please input emergency contact");

            }
            else if (string.IsNullOrEmpty(txtRelationship.Text))
            {

                MessageBox.Show("Please input your relationship");

            }
            else if (string.IsNullOrEmpty(txtSchool.Text))
            {

                MessageBox.Show("Please input the school you attend");

            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {

                MessageBox.Show("Please Input your address");

            } else if (string.IsNullOrEmpty(txtEmergencyName.Text)) {

                MessageBox.Show("Please Emergency Contact Name");

            } else if (cbFemale.Checked == false && cbMale.Checked == false) {

                MessageBox.Show("Please Select Gender");

            } else if (cbFemale.Checked == true && cbMale.Checked == true) {

                MessageBox.Show("Please One Gender");

            }
            else
            {

                try
                {
                    string firstname = txtFirstname.Text;
                    string lastName = txtLastName.Text;
                    long contact = long.Parse(txtContact.Text);
                    long emergency_contact = long.Parse(txtEmergencyContact.Text);
                    string relationship = txtRelationship.Text;
                    string school = txtSchool.Text;
                    string address = txtAddress.Text;
                    string emergencyName = txtEmergencyName.Text;

                    using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                    {
                        connect.Open();

                        byte[] imageData = null;
                        if (imgFilePath != null && imgFilePath != "")
                        {
                            using (FileStream fileStream = new FileStream(imgFilePath, FileMode.Open, FileAccess.Read))
                            {
                                imageData = new byte[fileStream.Length];
                                fileStream.Read(imageData, 0, imageData.Length);
                            }
                        }

                        string query = "INSERT INTO Tenant (FirstName, Lastname, Gender, Contact, Emergency_name, Emergency_Contact, Relationship, School, Address, Document_pic) " +
                            "VALUES (@FirstName, @Lastname, @gender, @Contact, @Emergency_name, @Emergency_Contact, @Relationship, @School, @Address, @Document_pic)";

                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", firstname);
                            cmd.Parameters.AddWithValue("@Lastname", lastName);

                            if (cbMale.Checked)
                            {

                                cmd.Parameters.AddWithValue("@gender", "Male");

                            }
                            else {

                                cmd.Parameters.AddWithValue("@gender", "Female");

                            }
                            cmd.Parameters.AddWithValue("@Contact", contact);
                            cmd.Parameters.AddWithValue("@Emergency_name", emergencyName);
                            cmd.Parameters.AddWithValue("@Emergency_Contact", emergency_contact);
                            cmd.Parameters.AddWithValue("@Relationship", relationship);
                            cmd.Parameters.AddWithValue("@School", school);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@Document_pic", imageData);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Done inserting customer personal info");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }


            }
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }
    }


    
}
