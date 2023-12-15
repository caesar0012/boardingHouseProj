using System;
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
                    string query = "Select Room_number, Description, Price, Capacity, Status from Room; ";

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

        private void btnAdd_Click(object sender, EventArgs e) //needs rework
        {
            if (string.IsNullOrEmpty(txtRoomNumber.Text)) {

                MessageBox.Show("Please Input room number");
                return;
            
            }
            else if (txtRoomNumber.Text == roomNum)
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {

                    connect.Open();

                    string query = "Update Room set Description = @desc, Capacity = @capacity, Price = @price, Status = @stats where Room_number = @roomNum";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {

                        cmd.Parameters.AddWithValue("@roomNum", int.Parse(txtRoomNumber.Text));
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@capacity", int.Parse(txtCapacity.Text));
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@stats", stats); ;


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Update Success");

                        dgRoom.Rows.Clear();
                        showData();
                    }
                }

                dgRoom.CellEndEdit += gridRoom_CellEndEdit;
            }
            else if (txtRoomNumber.Text != roomNum)
            {
                if (string.IsNullOrEmpty(txtCapacity.Text) && string.IsNullOrEmpty(txtDescription.Text) && string.IsNullOrEmpty(txtPrice.Text)) {

                    MessageBox.Show("");
                
                }
                try {

                    using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                    {

                        connect.Close();
                        connect.Open();

                        int room_number = int.Parse(txtRoomNumber.Text);
                        string description = txtDescription.Text;
                        int capacity = int.Parse(txtCapacity.Text);
                        double price = double.Parse((txtPrice.Text));
                        string status = "Available";

                        string query = "Insert into Room(Room_number, Description, Capacity, Price, Status) values " +
                            "(@Room_number, @Description, @Capacity, @Price, @Status)";

                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {

                            cmd.Parameters.AddWithValue("@Room_number", room_number);
                            cmd.Parameters.AddWithValue("@Description", description);
                        //    cmd.Parameters.AddWithValue("@Availability", capacity);
                            cmd.Parameters.AddWithValue("@Capacity", capacity);
                            cmd.Parameters.AddWithValue("@Price", price);
                            cmd.Parameters.AddWithValue("@Status", status); //Replace this with sql query

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Room Added successfully");

                            connect.Close();

                        }
                    }
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);

                }


            }
            else
            {

                MessageBox.Show("Invalid room Number");

            }
            try
            {

                dgRoom.Rows.Clear();
                showData();

            }
            catch { 
            
            }
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
                }
                else
                {
                    MessageBox.Show("One or more cell values are null.");
                }
            }


        }


        private void txtRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtRoomNumber_KeyPress(sender, e);
        }

        private void gridRoom_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
        }

        private void gridRoom_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment f1 = new frmPayment();
            f1.ShowDialog();
        }
    }
    }
   
