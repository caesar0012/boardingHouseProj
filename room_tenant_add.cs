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
        }
        private void btnClose_Click(object sender, EventArgs e) //close the exe
        {
            this.Close();
        }

        string tent_id;

        //this method is default load the list to the form
        private void loadList()
        {
            loadFilter("Select t1.Tenant_id, t1.FirstName + ' ' + t1.LastName as Name, \r\n    t1.Gender,\r\n    r1.room_number,\r\n    l1.assign_bed,\r\n    l1.MonthlyPayment,\r\n    l1.DepositAmount\r\nFROM Tenant as t1\r\nleft join Room as r1\r\non t1.Tenant_id = r1.Room_id\r\nleft JOIN lease_tbl as l1\r\non r1.Room_id = l1.room_id");
        }
        private void txtTenant_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { //if Keys.Enter was detected it activate the search button

                btnSearch_Click(sender, e);
            
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    string query = "SELECT t1.Tenant_id, " +
                                   "(t1.FirstName + ' ' + t1.LastName) AS Name, " +
                                   "Gender, l1.room_id AS Room_number, " +
                                   "l1.assign_bed AS Assign_bed, l1.StartLease, l1.EndLease " +
                                   "FROM Tenant AS t1 " +
                                   "LEFT JOIN lease_tbl AS l1 ON t1.Tenant_id = l1.lease_id " +
                                   "WHERE t1.Tenant_id = @tenant_id";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        if (int.TryParse(txtTenantId.Text, out int tenantId)) //if parsing is success it passes to tenantId
                        {
                            cmd.Parameters.AddWithValue("@tenant_id", tenantId);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);

                                dgAssignTenant.DataSource = dt;
                            }
                        }
                        else
                        {
                            // Handle the case where txtTenant_id.Text is not a valid integer.
                            MessageBox.Show("Please enter a valid Tenant ID.");
                        }
                    }
                }

                loadDate()
;
            }
            catch (Exception ex)
            {
                // Handle and log the exception appropriately.
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void room_tenant_add_Load(object sender, EventArgs e)
        {
            loadList();
            loadRoomAvailable();
            
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

        private void loadRoomAvailable() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "select r1.Room_number\r\n" +
                    "from Room as r1\r\n" +
                    "left join lease_tbl as l1\r\n" +
                    "on r1.Room_id = l1.lease_id";

                SqlCommand cmd = new SqlCommand(query, connect);

                using (SqlDataReader reader = cmd.ExecuteReader()) {

                    while (reader.Read()) {

                        cmbRoomNum.Items.Add(reader["Room_number"]);
                    
                    }
                }
            }
        }

        private void loadDate() {

/*            DateTime selectedDate = dtEndLease.Value;
            MessageBox.Show($"{selectedDate:yyyy-MM-dd}");

*/
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
                tent_id = lblTenantID.Text;
               
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
                    string query = "Update lease_tbl room_id";
                }
            }
            room_tenant_add_Load(sender, e);

        }

        private int setRoomNum() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {
                connect.Open();

                string query = "Select l1.lease_id, r1.Room_number\r\n" +
                    "from lease_tbl as l1\r\n" +
                    "left JOIN Room as r1\r\n" +
                    "on l1.room_id = r1.Room_number where l1.lease_id = @";

                using (SqlCommand cmd = new SqlCommand(query, connect)) { 
                    
                    
                
                
                
                }

            
            }

            return 0;
        
        }
    }
}
