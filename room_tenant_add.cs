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
                "on t1.Tenant_id = r1.Room_id");
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

                loadFilter(" select r1.Room_number, r1.Description, r1.allowed_gender as " +
                    "'Gender Allowed', r1.Capacity -count (l1.lease_id)as 'Available', r1.Capacity\r\n " +
                    "from Tenant " + "as t1\r\n left join Room as r1\r\n on r1.Room_id = t1.Tenant_id\r\n " +
                    "RIGHT join lease_tbl " + "as l1\r\n on r1.Room_id = l1.lease_id where t1.Archive = 0\r\n " +
                    "GROUP BY \r\n    r1.Room_number, " + "r1.Description, r1.allowed_gender, r1.Capacity;");

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

                loadFilter(" select r1.Room_number, r1.Description, r1.allowed_gender as 'Gender Allowed', " +
                    "r1.Capacity -count (l1.lease_id)as 'Available', r1.Capacity\r\n from Tenant as t1\r\n " +
                    "left join Room as r1\r\n on r1.Room_id = t1.Tenant_id\r\n left join lease_tbl as l1\r\n " +
                    "on r1.Room_id = l1.lease_id where r1.allowed_gender = 'Female' and t1.Archive = 0\r\n " +
                    "GROUP BY \r\n    r1.Room_number, r1.Description, r1.allowed_gender, r1.Capacity;");

            } else if (cmbFilter.SelectedIndex == 4) { //Male Room 

                loadFilter(" select r1.Room_number, r1.Description, r1.allowed_gender as 'Gender Allowed', " +
                    "r1.Capacity -count (l1.lease_id)as 'Available', r1.Capacity\r\n from Tenant as t1\r\n " +
                    "left join Room as r1\r\n on r1.Room_id = t1.Tenant_id\r\n left join lease_tbl as l1\r\n " +
                    "on r1.Room_id = l1.lease_id where r1.allowed_gender = 'Male' and t1.Archive = 0\r\n GROUP BY \r\n    " +
                    "r1.Room_number, r1.Description, r1.allowed_gender, r1.Capacity;");

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


                cmbRoomNum.Text = selectedRow.Cells["Room_number"].Value?.ToString();
                lblTenantID.Text = selectedRow.Cells["Tenant_id"].Value?.ToString();
               
            }
        }

        private void dtEndLease_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenantId.Text))
            {
                MessageBox.Show("Please input the tenant_id");
            }
            else if (dtEndLease.Value < dtStartLease.Value)
            {
                MessageBox.Show("End Lease should be after the Start Lease.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    //Tenant_id, room, id, bed, monthly payment, deposit, start lease, endlease
                    string query = "Update lease_tbl set room_id = @roomNum, assign_bed = @bedNum, MonthlyPayment = @monthly, " +
                        "DepositAmount = @deposit, StartLease = @startLease, EndLease = @endLease where Tenant_id = @tenantNum";

                    DateTime startDt = dtStartLease.Value;
                    DateTime endDt = dtEndLease.Value;

                    using (SqlCommand cmd = new SqlCommand(query, connect)) {


                        cmd.Parameters.AddWithValue("@roomNum", takeRoomNumber());
                        cmd.Parameters.AddWithValue("@bedNum", int.Parse(txtBed.Text));
                        cmd.Parameters.AddWithValue("@monthly", double.Parse(txtMonthlyPayment.Text));
                        cmd.Parameters.AddWithValue("@deposit", double.Parse(txtDeposit.Text));
                        cmd.Parameters.AddWithValue("@startLease", startDt.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@endLease", endDt.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@tenantNum", int.Parse(txtTenantId.Text));

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Update Sucess");
                    }

                }
            }
            room_tenant_add_Load(sender, e);

        }

        private int takeRoomNumber()
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "SELECT DISTINCT l1.room_id, r1.Room_number " +
                               "FROM lease_tbl AS l1 " +
                               "LEFT JOIN Room AS r1 ON r1.Room_id = l1.room_id " +
                               "WHERE r1.Room_number = @RoomNum";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@RoomNum", int.Parse(cmbRoomNum.Text));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming Room_number is of type int, use GetInt32 instead of GetString
                            return reader.GetInt32(0);
                        }
                        else
                        {
                            // Return 0 when no data is found
                            return 0;
                        }
                    }
                }
            }
        }



    }
}
