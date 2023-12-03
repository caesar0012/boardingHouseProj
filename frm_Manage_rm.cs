using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        }
        private void frmManage_rm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {

            DataTable dt = new DataTable();

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {

                connect.Open();

                string query1 = "Select Room_number, Description, Availability, Price, Status from Room; ";

                SqlCommand cmd = new SqlCommand(query1, connect);

                int rowsCount = 0;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        rowsCount++;

                        gridRoom.Rows.Add(reader["Room_number"], reader["Description"], reader["Availability"], reader["Price"], reader["Status"]);

                    }
                    reader.Close();
                }
                gridRoom.Sort(gridRoom.Columns["clmnRoom"], ListSortDirection.Ascending);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            if (txtRoomNumber.Text == roomNum)
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    string query = "Update Room set Description = @Desc, Capacity = @capacity, " +
                        "Price = @price, Status = @status";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {

                        cmd.Parameters.AddWithValue("@Desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@capacity", txtCapacity.Text);
                        cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                        cmd.Parameters.AddWithValue("@status", "Available");

                    }

                }
                MessageBox.Show("Update Success!");


            }
            else if (txtRoomNumber.Text != roomNum)
            {


                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {

                    connect.Close();
                    connect.Open();

                    int room_number = int.Parse(txtRoomNumber.Text);
                    string description = txtDescription.Text;
                    int capacity = int.Parse(txtCapacity.Text);
                    double price = double.Parse((txtPrice.Text));
                    string status = "Available";

                    string query = "Insert into Room(Room_number, Description, Availability, Capacity, Price, Status) values " +
                        "(@Room_number, @Description, @Availability, @Capacity, @Price, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {

                        cmd.Parameters.AddWithValue("@Room_number", room_number);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Availability", capacity);
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Status", status);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Room Added successfully");

                        connect.Close();

                    }
                }
            }
            else
            {

                MessageBox.Show("Invalid room Number");

            }

            gridRoom.Rows.Clear();
            showData();



        }

        public static string roomNum = "";

        private void gridRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /* try
             {

                 // Check if the clicked cell is in the "clmnTenant" and is a button
                 if (e.ColumnIndex == gridRoom.Columns["clmnRoom"].Index && e.RowIndex >= 0)
                 {
                     // Get the value in a specific column of the clicked row
                     string roomNumber = gridRoom.Rows[e.RowIndex].Cells["clmnRoom"].Value.ToString();

                     roomNum = roomNumber;

                     MessageBox.Show($"Button clicked in row {e.RowIndex + 1}. Room Number: {roomNumber}");

                 }
                 else
                 {

                     MessageBox.Show("Error: Invalid");

                 }

             }
             catch (Exception ex)
             {

                 MessageBox.Show("Error:" + ex.Message);

             }*/
        }

        private void gridRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if the clicked cell is not in the header row
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = gridRoom.Rows[e.RowIndex];

                // Select the entire row
                selectedRow.Selected = true;

                // Use the column names directly instead of retrieving index
                string roomNumber = selectedRow.Cells["clmnRoom"].Value?.ToString();
                string desc = selectedRow.Cells["clmnDesc"].Value?.ToString();
                string capacity = selectedRow.Cells["clmnCapacity"].Value?.ToString();
                string price = selectedRow.Cells["clmnPrice"].Value?.ToString(); // Fix the column name here

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
    }
}
