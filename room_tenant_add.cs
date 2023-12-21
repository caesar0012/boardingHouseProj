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
using System.Runtime.InteropServices;
using System.Net.Configuration;
using System.Xml.Linq;
using System.Diagnostics;
using System.Security.Cryptography;

namespace boardingHouseProj
{
    public partial class room_tenant_add : Form
    {
        public room_tenant_add()
        {
            InitializeComponent();
            loadComboRoom();


        }
        private void btnClose_Click(object sender, EventArgs e) //close the exe
        {
            this.Close();
        }

        //this method is default load the list to the form
        private void loadList()
        {
            loadFilter("SELECT t1.Tenant_id,\r\n       " +
                "t1.FirstName + ' ' + t1.LastName AS Name,\r\n\t   " +
                "r1.room_number,\r\n\t   " +
                "l1.assign_bed,\r\n\t   " +
                "l1.MonthlyPayment,\r\n\t   " +
                "l1.DepositAmount,\r\n\t   " +
                "l1.StartLease,\r\n\t   " +
                "l1.EndLease\r\n" +
                "FROM Tenant AS t1\r\n" +
                "LEFT JOIN Lease_tbl AS l1 \r\n" +
                "ON t1.Tenant_id = l1.Tenant_id\r\n" +
                "left join Room as r1\r\n" +
                "on l1.room_id = r1.Room_id");
        }

        private void room_tenant_add_Load(object sender, EventArgs e)
        {
            loadList();

        }
        private void loadComboRoom() {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {
                string query = "Select Room_number from Room";
                
                connect.Open();

                SqlCommand cmd = new SqlCommand(query, connect);

                using (SqlDataReader reader = cmd.ExecuteReader()) {

                    while (reader.Read()) {

                        cmbRoomNum.Items.Add(reader["Room_number"].ToString());
                    
                    }
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 0) { //Default Room

                loadList();

            } else if (cmbFilter.SelectedIndex == 1) { //Available Room

                loadFilter("SELECT\r\n    " +
                    "r1.Room_number,\r\n    " +
                    "r1.Description,\r\n   " +
                    " r1.allowed_gender as 'Gender Allowed',\r\n    " +
                    "r1.Capacity - COALESCE(COUNT(l1.lease_id), 0) as 'Available',\r\n    " +
                    "r1.Capacity\r\n" +
                    "FROM\r\n   " +
                    "Room as r1\r\n" +
                    "LEFT JOIN\r\n    " +
                    "lease_tbl as l1 ON l1.room_id = r1.Room_id\r\n" +
                    "GROUP BY\r\n    " +
                    "r1.Room_number, r1.Description, r1.allowed_gender, r1.Capacity");

            }
            else if (cmbFilter.SelectedIndex == 2) //Tenant without Room
            {

                loadFilter("select t1.Tenant_id, t1.FirstName + ' ' + t1.LastName as Name, t1.Gender, " +
                    "r1.Room_number, l1.assign_bed, l1.StartLease, l1.EndLease\r\n from Tenant as t1\r\n " +
                    "left join Room as r1\r\n on r1.Room_id = t1.Tenant_id\r\n left join lease_tbl as l1\r\n " +
                    "on r1.Room_id = l1.lease_id where Room_number is null");

            }
            else if (cmbFilter.SelectedIndex == 3) //Female Room
            {

                loadFilter("SELECT\r\n    " +
                    "r1.Room_number,\r\n    " +
                    "r1.Description,\r\n   " +
                    " r1.allowed_gender as 'Gender Allowed',\r\n    " +
                    "r1.Capacity - COALESCE(COUNT(l1.lease_id), 0) as 'Available',\r\n    " +
                    "r1.Capacity\r\n" +
                    "FROM\r\n   " +
                    "Room as r1\r\n" +
                    "LEFT JOIN\r\n    " +
                    "lease_tbl as l1 ON l1.room_id = r1.Room_id where r1.allowed_gender = 'Female'\r\n" +
                    "GROUP BY\r\n    " +
                    "r1.Room_number, r1.Description, r1.allowed_gender, r1.Capacity");

            } else if (cmbFilter.SelectedIndex == 4) { //Male Room 

                loadFilter("SELECT\r\n    " +
                    "r1.Room_number,\r\n    " +
                    "r1.Description,\r\n   " +
                    " r1.allowed_gender as 'Gender Allowed',\r\n    " +
                    "r1.Capacity - COALESCE(COUNT(l1.lease_id), 0) as 'Available',\r\n    " +
                    "r1.Capacity\r\n" +
                    "FROM\r\n   " +
                    "Room as r1\r\n" +
                    "LEFT JOIN\r\n    " +
                    "lease_tbl as l1 ON l1.room_id = r1.Room_id where r1.allowed_gender = 'Male  '\r\n" +
                    "GROUP BY\r\n    " +
                    "r1.Room_number, r1.Description, r1.allowed_gender, r1.Capacity");

            }
        }
        private void loadFilter(string query) { //this a method with just a query, loads the data to datagrid

            try {

                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) { 
            
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connect)) {

                        using (SqlDataReader reader = cmd.ExecuteReader()) { 
                    
                                DataTable dt = new DataTable();

                                dt.Load(reader);
                                dgAssignTenant.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message); //Shows the message in messagebox for whats the error
            
            }
        }


        private void dgAssignTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {

                DataGridViewRow selectedRow = dgAssignTenant.Rows[e.RowIndex];

                selectedRow.Selected = true;

                if (dgAssignTenant.Columns.Contains("Tenant_id"))
                {
                    txtTenantId.Text = selectedRow.Cells["Tenant_id"].Value?.ToString();
                }
                if (dgAssignTenant.Columns.Contains("assign_bed"))
                {
                    txtBed.Text = selectedRow.Cells["assign_bed"].Value?.ToString();
                }
                if (dgAssignTenant.Columns.Contains("StartLease") && dgAssignTenant.Columns.Contains("EndLease"))
                {
                    if (DateTime.TryParse(selectedRow.Cells["StartLease"].Value?.ToString(),
                   out DateTime startDate) && DateTime.TryParse
                   (selectedRow.Cells["EndLease"].Value?.ToString(), out DateTime endDate))
                    { //value?.string checks if the cell is null

                        dtStartLease.Value = startDate;
                        dtEndLease.Value = endDate;

                    }

                }
                txtMonthlyPayment.Text = selectedRow.Cells["MonthlyPayment"].Value.ToString();
                txtDeposit.Text = selectedRow.Cells["DepositAmount"].Value.ToString();


                cmbRoomNum.Text = selectedRow.Cells["Room_number"].Value?.ToString();
                lblSample.Text = TakeRoomNumber().ToString();
               
            }
        }

        private void dtEndLease_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM Lease_tbl WHERE Tenant_id = @tenant_id";

                DateTime startDt = dtStartLease.Value;
                DateTime endDt = dtEndLease.Value;

                int roomNum1 = TakeRoomNumber();

                if (string.IsNullOrEmpty(txtTenantId.Text)) {

                    MessageBox.Show("Please Select Tenant ID from the table");

                } else if (string.IsNullOrEmpty(cmbRoomNum.Text)) {

                    MessageBox.Show("Please Select Room Number");

                }
                else if (string.IsNullOrEmpty(txtBed.Text))
                {

                    MessageBox.Show("Please Select Bed Number");

                }
                else if (string.IsNullOrEmpty(txtMonthlyPayment.Text))
                {

                    MessageBox.Show("Please Input Monthly Payment of the Tenant");

                }
                else if (string.IsNullOrEmpty(txtDeposit.Text))
                {

                    MessageBox.Show("Please insert deposit amount of the Tenant");

                } else if (IsRoomFull()) {

                    MessageBox.Show("Room is full");
                
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@tenant_id", int.Parse(txtTenantId.Text));
                        int existLease = (int)cmd.ExecuteScalar();

                        if (existLease > 0)
                        {
                            query = "UPDATE lease_tbl SET room_id = @roomId, assign_bed = @assignBed, " +
                                    "MonthlyPayment = @monthly, DepositAmount = @deposit WHERE Tenant_id = @tenantID";

                            using (SqlCommand cmd1 = new SqlCommand(query, connect))
                            {
                                cmd1.Parameters.AddWithValue("@roomId", roomNum1);
                                cmd1.Parameters.AddWithValue("@assignBed", txtBed.Text);
                                cmd1.Parameters.AddWithValue("@monthly", double.Parse(txtMonthlyPayment.Text));
                                cmd1.Parameters.AddWithValue("@deposit", double.Parse(txtDeposit.Text));
                                cmd1.Parameters.AddWithValue("@tenantID", int.Parse(txtTenantId.Text));

                                cmd1.ExecuteNonQuery();
                            }

                            MessageBox.Show("Update Bro");
                        }
                        else
                        {
                            query = "INSERT INTO lease_tbl (Tenant_id, Employee_id, room_id, assign_bed, " +
                                    "MonthlyPayment, DepositAmount, StartLease, EndLease) " +
                                    "VALUES (@tenant_id, @emp_id, @room_id, @assignBed, @monthly, @Deposit, @start, @end)";

                            using (SqlCommand command = new SqlCommand(query, connect))
                            {
                                command.Parameters.AddWithValue("@tenant_id", int.Parse(txtTenantId.Text));
                                command.Parameters.AddWithValue("@emp_id", frmLogin.employee_id);
                                command.Parameters.AddWithValue("@room_id", roomNum1);
                                command.Parameters.AddWithValue("@assignBed", int.Parse(txtBed.Text));
                                command.Parameters.AddWithValue("@monthly", double.Parse(txtMonthlyPayment.Text));
                                command.Parameters.AddWithValue("@Deposit", double.Parse(txtDeposit.Text));
                                command.Parameters.AddWithValue("@start", startDt);
                                command.Parameters.AddWithValue("@end", endDt);

                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Create Bro");
                        }
                    }
                }
            }

            loadList();
        }


        private int TakeRoomNumber()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    string query = "Select Room_id \r\n" +
                        "from Room\r\n" +
                        "where Room_number = @RoomNum";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Check if cmbRoomNum.Text is a valid integer before parsing
                        if (int.TryParse(cmbRoomNum.Text, out int roomNum))
                        {
                            cmd.Parameters.AddWithValue("@RoomNum", roomNum);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Assuming Room_id is of type int, use GetInt32 instead of GetString
                                    return reader.GetInt32(0); // Use index 0 for Room_id
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log, display, etc.)
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Return a default value when no data is found or an error occurs
            return 0;
        }



        private void txtTenantId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBed_KeyDown(object sender, KeyEventArgs e) // txt Bed only accepts number
        {
            // Allow only numeric input and control characters (like Backspace)
            if (!(char.IsControl((char)e.KeyCode) || char.IsDigit((char)e.KeyCode)))
            {
                e.SuppressKeyPress = true; // Suppress the key press
            }
        }

        private bool IsRoomFull()
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();
                string query = "SELECT " +
                               "r1.Room_number, " +
                               "r1.Allowed_gender AS 'Gender Allowed', " +
                               "(r1.Capacity - COALESCE(COUNT(l1.lease_id), 0)) AS 'Available', " +
                               "r1.Capacity " +
                               "FROM Room AS r1 " +
                               "LEFT JOIN lease_tbl AS l1 ON l1.room_id = r1.Room_id " +
                               "WHERE r1.Room_number = @room_num " +
                               "GROUP BY r1.Room_number, r1.Allowed_gender, r1.Capacity;";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@room_num", cmbRoomNum.Text);

                int availableCapacity = 0;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming 'Available' is an int, use GetInt32 method
                        availableCapacity = reader.GetInt32(reader.GetOrdinal("Available"));
                    }
                }

                return availableCapacity == 0;
            }
        }


    }
}
