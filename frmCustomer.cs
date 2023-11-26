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
            else if (string.IsNullOrEmpty(txtMiddleName.Text))
            {

                MessageBox.Show("Pls input middle name");

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

            }
            else
            {
                

                    string firstname = txtFirstname.Text;
                    string middlename = txtMiddleName.Text;
                    string lastName = txtLastName.Text;
                    long contact = long.Parse(txtContact.Text);
                    long emergency_contact = long.Parse(txtEmergencyContact.Text);
                    string relationship = txtRelationship.Text;
                    string school = txtSchool.Text;
                    string address = txtAddress.Text;


                try
                {
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


                        string query = "INSERT INTO Customer_Personal_Info (firstName, middleName, lastName, Contact, Emergency_Contact, Relationship, School, Address, Document) " +
                            "VALUES (@fName, @midName, @lName, @contact, @emergencyContact, @relationship, @school, @address, @document)";

                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@fName", firstname);
                            cmd.Parameters.AddWithValue("@midName", middlename);
                            cmd.Parameters.AddWithValue("@lName", lastName);
                            cmd.Parameters.AddWithValue("@contact", contact);
                            cmd.Parameters.AddWithValue("@emergencyContact", emergency_contact);
                            cmd.Parameters.AddWithValue("@relationship", relationship);
                            cmd.Parameters.AddWithValue("@school", school);
                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.Parameters.AddWithValue("@document", imageData);

                            cmd.ExecuteNonQuery();

                            Console.WriteLine("Done inserting customer personal info");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }


            }





        }
        }


    
}
