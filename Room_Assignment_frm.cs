using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class Room_Assignment_frm : Form
    {
        public Room_Assignment_frm()
        {
            InitializeComponent();
        }

        string imgFilePath;
        private void Room_Assignment_frm_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ValidateFields();
            insertTenant();
            clear();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdCustomer = new OpenFileDialog();

            ofdCustomer.Filter = "png files(*.png) | *.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (ofdCustomer.ShowDialog() == DialogResult.OK)
            {

                imgFilePath = ofdCustomer.FileName.ToString();

                btnBrowse.Text = Path.GetFileName(imgFilePath);

            }
        }

        private void SetFontColorBasedOnEmpty(TextBox textBox, Label label01, ref bool isEmptyFlag)
        {
            //ref isEmptyFlag mean, if any changes made it will affect all the variables like static var behavior
           
            if (string.IsNullOrEmpty(textBox.Text))
            {
                label01.ForeColor = Color.Red;
                isEmptyFlag = true;
            }
            else
            {
                label01.ForeColor = SystemColors.ControlText; // Reset to default color
            }
        }

        void ValidateFields()
        {
            bool isEmptyFlag = false;  // Flag to track if any TextBox is empty

            SetFontColorBasedOnEmpty(txtFirstName, lblFirstName, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtLastName, lblLastName, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtAddress, lblAddress, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtBed, lblBed, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtContact, lblContact, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtDeposit, lblDeposit, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtEmergencyContact, lblEmgencyContact, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtGuardian, lblGuardian, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtRelationship, lblRelation, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtRent, lblRent, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtRoom, lblRoom, ref isEmptyFlag);
            SetFontColorBasedOnEmpty(txtSchool, lblSchool, ref isEmptyFlag);

            if (cmbGender.Text == "")
            {
                lblGender.ForeColor = Color.Red;
                isEmptyFlag = true;
            }
            else
            {
                lblGender.ForeColor = SystemColors.ControlText; // Reset to default color
            }

            if (string.IsNullOrEmpty(imgFilePath))
            {
                lblDocu.ForeColor = Color.Red;
                isEmptyFlag = true;
            }
            else
            {
                lblDocu.ForeColor = SystemColors.ControlText; // Reset to default color
            }

            if (isEmptyFlag)
            {
                MessageBox.Show("Please fill the fields");
            }
        }

        void clear() {

            txtAddress.Clear();
            txtBed.Clear();
            txtContact.Clear();
            txtDeposit.Clear();
            txtEmergencyContact.Clear();
            txtFirstName.Clear();
            txtGuardian.Clear();
            txtLastName.Clear();
            txtRelationship.Clear();
            txtRent.Clear();
            txtRoom.Clear();
            txtSchool.Clear();
            cmbGender.Text = "";
            imgFilePath = "";
            btnBrowse.Text = "Browse";

        }

        void insertTenant() {

            try {

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

                    string query = "INSERT INTO Tenant (FirstName, Lastname, Gender, Contact, Guardian, Emergency_Contact, Relationship, School, Address, Document_pic) " +
                                "VALUES (@FirstName, @Lastname, @gender, @Contact, @guardian, @Emergency_Contact, @Relationship, @School, @Address, @Document_pic)";

                    SqlCommand cmd = new SqlCommand(query, connect);

                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@Lastname", txtLastName.Text);

                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@Contact", long.Parse(txtContact.Text));
                    cmd.Parameters.AddWithValue("@guardian", txtGuardian.Text);
                    cmd.Parameters.AddWithValue("@Emergency_Contact", txtEmergencyContact.Text);
                    cmd.Parameters.AddWithValue("@Relationship", txtRelationship.Text);
                    cmd.Parameters.AddWithValue("@School", txtSchool.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Document_pic", imageData);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tenant information has been successfully added");

                }
            }
            catch{

                MessageBox.Show("Error: Failed to Register the Tenant");
            
            }
        }

        void loadDataGrid() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Select * from Room";

                SqlCommand cmd = new SqlCommand(query, connect);

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgRoom.DataSource = dt;
            }
        }
    }
}
