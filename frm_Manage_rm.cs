﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace boardingHouseProj
{
    public partial class frmManage_rm : Form
    {
        public frmManage_rm()
        {
            InitializeComponent();
            dgRoom.DataError += dataGridView1_DataError;

        }

        private void frmManage_rm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private static string stats;
        public static string roomNum = "";
        private void showData()
        {

            try
            {
                string query = " Select Room_number, Description, allowed_gender as 'Allowed Gender', Price, Capacity, Status from Room;";

                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            DataTable dt = new DataTable();

                            dt.Load(reader);
                            dgRoom.DataSource = dt;
                        }
                    }
                    dgRoom.Sort(dgRoom.Columns["Room_number"], System.ComponentModel.ListSortDirection.Ascending);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); //Shows the message in messagebox for whats the error

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Display the default error dialog
            MessageBox.Show("Error in data: " + e.Exception.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Optionally, you can cancel the event to suppress the default error dialog
            e.Cancel = true;
        }

        private void gridRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if the clicked cell is not in the header row
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgRoom.Rows[e.RowIndex];

                // Select the entire row
                selectedRow.Selected = true;

                // Use the column names directly instead of retrieving index
                string roomNumber = selectedRow.Cells["Room_number"].Value?.ToString();
                string desc = selectedRow.Cells["Description"].Value?.ToString();
                string capacity = selectedRow.Cells["Capacity"].Value?.ToString();
                string price = selectedRow.Cells["Price"].Value?.ToString(); // Fix the column name here

                string status = selectedRow.Cells["Status"].Value?.ToString(); // Fix the column name here

                stats = status;

                roomNum = roomNumber;

                // Check if any cell value is null
                if (roomNumber != null && desc != null && capacity != null && price != null)
                {
                    // Set the values to the text boxes
                    txtRoomNumber.Text = roomNumber;
                    txtDescription.Text = desc;
                    txtCapacity.Text = capacity;
                    txtPrice.Text = price;
                    cmbGender.Text = selectedRow.Cells["Allowed Gender"].Value?.ToString();
                    cmbStatus.Text = selectedRow.Cells["Status"].Value?.ToString();
                }
                else
                {
                    MessageBox.Show("One or more cell values are null.");
                }
            }
        }


        private void txtRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key is not a control key, a digit, or a minus sign
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }// Check if the key is not a control key, a digit, or a minus sign
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '-')
            {
                e.Handled = true; // Ignore the '-' key
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment_Frm f1 = new Payment_Frm();
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(f1);
            f1.BringToFront();


            f1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string roomNumber = txtRoomNumber.Text;
            if (string.IsNullOrEmpty(txtRoomNumber.Text))
            {

                MessageBox.Show("Please Input Room Number of the Room");

            }
            else if (string.IsNullOrEmpty(txtDescription.Text))
            {

                MessageBox.Show("Please Input Description of the Room");


            }
            else if (string.IsNullOrEmpty(cmbGender.Text))
            {

                MessageBox.Show("Please Select a Gender for the Room");

            }
            else if (string.IsNullOrEmpty(txtCapacity.Text))
            {

                MessageBox.Show("Please Input Capacity of the Room");

            }
            else if (string.IsNullOrEmpty(txtPrice.Text))
            {

                MessageBox.Show("Please Input Price of the Room");


            }
            else if (string.IsNullOrEmpty(cmbStatus.Text))
            {

                MessageBox.Show("Please Select Status of the Room");

            }
            else if (RoomExists(roomNumber)){
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) { 
                    
                    connect.Open();

                    string query = "Update Room set Description = @desc, allowed_gender = @gender," +
                        "Capacity = @cap, Price = @price, Status = @stats where Room_number = @roomNum";

                    using (SqlCommand cmd = new SqlCommand(query, connect)) {

                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@cap", int.Parse(txtCapacity.Text));
                        cmd.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));

                        if (cmbStatus.Text == "Available")
                        {

                            cmd.Parameters.AddWithValue("@stats", cmbStatus.Text);

                        }
                        else {

                            MaintenanceRequest m1 = new MaintenanceRequest();
                            m1.ShowDialog();
                            cmd.Parameters.AddWithValue("@stats", cmbStatus.Text);

                        }
                        cmd.Parameters.AddWithValue("@roomNum", txtRoomNumber.Text);

                        cmd.ExecuteNonQuery();

                    }
                }
                    MessageBox.Show("Room Updated");
                    
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) { 
                    
                    connect.Open();

                    string query = "Insert into Room(Room_number, Description, allowed_gender, Capacity, Price, Status, staff_id) values " +
                        "(@roomNum, @desc, @gender, @cap, @price, @stats, @staff_id)";

                    using (SqlCommand cmd = new SqlCommand(query, connect)) {

                        cmd.Parameters.AddWithValue("@roomNum", txtRoomNumber.Text);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@cap", int.Parse(txtCapacity.Text));
                        cmd.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@stats", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@staff_id", frmLogin.staff_id);

                        cmd.ExecuteNonQuery();
                    }
                }
                    MessageBox.Show("Room Added");
            }
            frmManage_rm_Load(sender, e);
        }

        private bool RoomExists(string roomNumber)
        {
            using (SqlConnection connection = new SqlConnection(ConnectSql.connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Room WHERE Room_number = @RoomNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", roomNumber);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
   
