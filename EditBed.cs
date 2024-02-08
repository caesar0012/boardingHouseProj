using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace boardingHouseProj
{
    public partial class EditBed : Form
    {
        public EditBed()
        {
            InitializeComponent();
        }

        private void EditBed_Load(object sender, EventArgs e)
        {
            loadData();
            loadTenant();
            lblRoomNum.Text = frmManage_rm.roomNum;
        }

        private void loadData() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = @"select
                    b1.BedNumber,
                    t1.FirstName + ' ' + t1.LastName as Name,
                    l1.StartLease,
                    l1.EndLease,
                    b1.status as Status
                from bed_tbl as b1
                left join lease_tbl as l1
                on  b1.bed_id = l1.bed_id
                left join Tenant as t1
                on l1.Tenant_id = t1.Tenant_id
                left join Room as r1
                on b1.RoomID = r1.Room_id
                where l1.lease_id is not null and r1.Room_number = '" + frmManage_rm.roomNum + "'";

                SqlCommand cmd = new SqlCommand(query, connect);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {

                    dgBed.Rows.Add(reader["BedNumber"], reader["Name"], reader["StartLease"], reader["EndLease"], reader["Status"]);

                }
            }
        }
        private void dgBed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    DataGridViewRow selectedRow = dgBed.Rows[e.RowIndex];
                    selectedRow.Selected = true;

                    txtBed.Text = selectedRow.Cells["clmnBed"].Value?.ToString();
                    cmbTenant.Text = selectedRow.Cells["clmnName"].Value?.ToString();
                    cmbBedStats.Text = selectedRow.Cells["clmnStatus"].Value?.ToString();



                }
                else { 
                
                
                }
            }
            catch { 
            
                //do nothing
            
            }
        }

        void updateBed() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "";

                SqlCommand cmd = new SqlCommand(query, connect);



                cmd.ExecuteNonQuery();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateTenantLease();
        }

        void loadTenant() {

            cmbTenant.Items.Clear();

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = @"SELECT
                                    t1.FirstName + ' ' + t1.LastName as Name
                                from Tenant as t1
                                left JOIN lease_tbl as l1
                                on t1.Tenant_id = l1.Tenant_id 
                                where t1.archive = 0 and l1.bed_id is NULL";

                SqlCommand cmd = new SqlCommand(query, connect);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {

                    cmbTenant.Items.Add(reader["Name"]);
                }
            }
        }

        void removeTenant() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = @"update lease_tbl set bed_id = null
	                                where Tenant_id = 
	                                (Select Tenant_id from Tenant 
	                                where FirstName + ' ' + LastName = @TName)";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@TName", cmbTenant.Text);
                cmd.ExecuteNonQuery();

                
            
            }
        }

        private void dgBed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgBed.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's choice
                if (result == DialogResult.Yes)
                {
                    removeTenant();
                    dgBed.Rows.Clear();
                    loadData();
                    loadTenant();
                }
                else
                {
                    //do nothing
                }
            }
        }

        void updateTenantLease() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = @"Update lease_tbl set 
	                                bed_id = (select 
	                                b1.bed_id 
                                from bed_tbl as b1
                                left join Room as r1
                                on b1.RoomID = r1.Room_id
                                where r1.Room_number = @roomNum), 
                                    staff_id = @staffID
                                where Tenant_id = (
	                                Select Tenant_id from Tenant where
	                                FirstName + ' ' + Lastname = @Tname)";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@roomNum", frmManage_rm.roomNum);
                cmd.Parameters.AddWithValue("@Tname", cmbTenant.Text);
                cmd.Parameters.AddWithValue("@staffID", frmLogin.staff_id);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Done Update");
                dgBed.Rows.Clear();
                loadData();
                loadTenant();
            }
        }
    }
}
