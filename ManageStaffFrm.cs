using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class ManageStaffFrm : Form
    {
        public ManageStaffFrm()
        {
            InitializeComponent();
            btnRestore.Visible = false;
        }

        static string ID;


        private void loadTenant()
        {
            string query = "SELECT " +
                           "s1.Staff_id AS ID, " +
                           "s1.FirstName + ' ' + s1.LastName AS Name, " +
                           "s1.userName, " +
                           "s1.password, " +
                           "s1.Role " +
                           "FROM Staff_acc AS s1 where Archive = 0";
            FilterData(query);
        }

        private void FilterData(string query) {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand(query, connect);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Assuming dgTenant is your DataGridView
                        dgTenant.Rows.Add(reader["ID"], reader["Name"], reader["userName"], reader["password"], reader["Role"]);
                    }
                }
            }

                    dgTenant.AllowUserToAddRows = false;
        }

        private void ManageTenantFrm_Load(object sender, EventArgs e)
        {
            loadTenant();
        }

        private void deleteClick(int num1) {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Update Staff_acc set Archive = @arch where Staff_id = @staffID";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    cmd.Parameters.AddWithValue("@staffID", ID);
                    cmd.Parameters.AddWithValue("@arch", num1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");

                }
            }
        }

        private void dgTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgTenant.Rows[e.RowIndex];

                    selectedRow.Selected = true;

                    string num1 = selectedRow.Cells["clmnID"].Value?.ToString();

                    ID = num1;
                        txtID.Text = ID.ToString();

                    if (dgTenant.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                    {
                        DialogResult result = MessageBox.Show("Do you want to delete " + txtFirstName.Text + " " + txtLastName.Text + "?"
                            , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ID == frmLogin.staff_id)
                        {
                            MessageBox.Show("You cannot delete your own account. Only administrators or other authorized users have the permission to delete accounts.",
                                "Delete Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // Check the user's choice
                        if (result == DialogResult.Yes)
                        {
                            deleteClick(1); //sets the archive flag to 1
                            dgTenant.Rows.Clear();
                            ManageTenantFrm_Load(sender, e);
                            clear();

                        }
                        else
                        {
                            // User clicked No, do nothing or handle accordingly
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                Console.WriteLine($"Error in dgTenant_CellClick: {ex.Message}");
            }

        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Select * from Staff_acc where staff_id = @staffID";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("staffID", ID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read()) {

                        txtFirstName.Text = reader["FirstName"].ToString();
                        txtLastName.Text = reader["LastName"].ToString();
                        txtUserName.Text = reader["UserName"].ToString();
                        txtPassword.Text = reader["Password"].ToString();
                        cmbRole.Text = reader["Role"].ToString();
                      //  txtLastName.Text = reader["LastName"].ToString();

                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateTenant();
            dgTenant.Rows.Clear();
            ManageTenantFrm_Load(sender, e);
        }

        private void updateTenant() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Update Staff_acc set FirstName = @fname, LastName = @lname, UserName = @user, Password = @pass, Role = @role where Staff_id = @staffID";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@user", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                    cmd.Parameters.AddWithValue("@staffID", ID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Update Success");

                }
            }
        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbShow.Text == "Recovery")
            {
                btnRestore.Visible = true;
                dgTenant.Rows.Clear();
                dgTenant.Columns["clmnDel"].Visible = false;
                string query = "SELECT " +
                           "s1.Staff_id AS ID, " +
                           "s1.FirstName + ' ' + s1.LastName AS Name, " +
                           "s1.userName, " +
                           "s1.password, " +
                           "s1.Role " +
                           "FROM Staff_acc AS s1 where Archive = 1";
                FilterData(query);

                btnUpdate.Enabled = false;

            }
            else {
                dgTenant.Rows.Clear();
                dgTenant.Columns["clmnDel"].Visible = true;
                ManageTenantFrm_Load(sender, e);
                btnRestore.Visible = false;
                btnUpdate.Enabled = true;
            }
        }

        private void btnRestore_Click_1(object sender, EventArgs e)
        {
            dgTenant.Rows.Clear();

            string query = "SELECT " +
           "s1.Staff_id AS ID, " +
           "s1.FirstName + ' ' + s1.LastName AS Name, " +
           "s1.userName, " +
           "s1.password, " +
           "s1.Role " +
           "FROM Staff_acc AS s1 where Archive = 1";
            FilterData(query);

            deleteClick(0);

            dgTenant.Rows.Clear();

            string query1 = "SELECT " +
           "s1.Staff_id AS ID, " +
           "s1.FirstName + ' ' + s1.LastName AS Name, " +
           "s1.userName, " +
           "s1.password, " +
           "s1.Role " +
           "FROM Staff_acc AS s1 where Archive = 1";
            FilterData(query1);

        }

        void clear() {

            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
            cmbRole.Text = "";
        
        }
    }
}
