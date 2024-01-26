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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

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
            registerLease();

            /*if (CheckBed())
            {

                return;

            }
            else {
                
            }*/
            
            
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

        void clear()
        {

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

        void insertTenant()
        {
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

                    if (imageData != null)
                    {

                        cmd.Parameters.AddWithValue("@Document_pic", imageData);

                    }
                    else {

                        return;
                        
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tenant information has been successfully added");
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        void loadDataGrid()
        {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {

                connect.Open();

                string query = "SELECT \r\n    " +
                    "r1.Room_number AS Room,\r\n    " +
                    "r1.Description,\r\n    " +
                    "r1.Price,\r\n    " +
                    "r1.allowed_gender AS Gender,\r\n    " +
                    "r1.capacity - COUNT(b1.RoomID) AS Avail,\r\n    " +
                    "r1.Capacity\r\n" +
                    "FROM Room AS r1\r\n" +
                    "LEFT JOIN bed_tbl AS b1 ON r1.Room_id = b1.RoomID where r1.Archive = 0" +
                    "GROUP BY \r\n    " +
                    "r1.Room_number, \r\n    " +
                    "r1.Description, \r\n    " +
                    "r1.Price,\r\n    " +
                    "r1.allowed_gender,\r\n    " +
                    "r1.Capacity; -- Only include non-aggregated columns in the GROUP BY clause\r\n";

                SqlCommand cmd = new SqlCommand(query, connect);

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgRoom.DataSource = dt;
            }
        }

        private void dgRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgRoom.Rows[e.RowIndex];

                txtRoom.Text = selectedRow.Cells["Room"].Value.ToString();
                string Rent = selectedRow.Cells["Price"].Value.ToString();

                txtRent.Text = Rent;

                double depo = double.Parse(Rent) * 2;

                txtDeposit.Text = depo.ToString();

            }
        }

        bool CheckBed()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    string query = "SELECT COUNT(b1.BedNumber) " +
                                   "FROM bed_tbl AS b1 " +
                                   "LEFT JOIN Room AS r1 ON b1.RoomID = r1.Room_id " +
                                   "WHERE r1.Room_number = @roomNum and BedNumber = @bedNum";

                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@roomNum", txtRoom.Text);
                        cmd.Parameters.AddWithValue("@bedNum", txtBed.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Bed Taken");
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Log the exception or handle it appropriately.
            }

            return false;
        }

        void registerLease()
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                DateTime startDt = dtStart.Value;
                DateTime endDt = dtEnd.Value;

                string query = @"INSERT INTO lease_tbl(Tenant_id, Staff_id, Bed_id, MonthlyPayment, DepositAmount, StartLease, EndLease)
                                SELECT
                                    (Select Tenant_id from Tenant where FirstName = @fname and Lastname  = @lname),
                                    @staffID,
                                    (Select

                                            b1.bed_id
                                        from bed_tbl as b1

                                        left join Room as r1

                                        on b1.RoomID = r1.Room_id

                                        where r1.Room_number = @roomNum and b1.BedNumber = @bedNum),
                                    @rent,
                                    @deposit,
                                    @startLease,
                                    @endLease";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@staffID", frmLogin.staff_id);
                    cmd.Parameters.AddWithValue("@rent", double.Parse(txtRent.Text));
                    cmd.Parameters.AddWithValue("@deposit", double.Parse(txtDeposit.Text));
                    cmd.Parameters.AddWithValue("@startLease", startDt);
                    cmd.Parameters.AddWithValue("@endLease", endDt);
                    cmd.Parameters.AddWithValue("@bedNum", txtBed.Text);
                    cmd.Parameters.AddWithValue("@roomNum", txtRoom.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done Registering a lease");
                    clear();
                }
            }
        }

    }
}
