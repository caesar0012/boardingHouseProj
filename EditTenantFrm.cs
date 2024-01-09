using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class EditTenantFrm : Form
    {
        public EditTenantFrm()
        {
            InitializeComponent();
            btnRestore.Visible = false;
        }

        public static int tenantID = 0;
        private void TenantManage_Load(object sender, EventArgs e)
        {
            string query = "Select \r\n    " +
                    "Tenant_id as ID,\r\n    " +
                    "FirstName + ' ' + LastName as Name,\r\n    " +
                    "Gender,\r\n    " +
                    "Contact,\r\n    " +
                    "Emergency_name,\r\n    " +
                    "Emergency_contact, \r\n    " +
                    "Relationship,\r\n    " +
                    "School,\r\n    " +
                    "Address\r\n" +
                    "from Tenant where Archive = 0";

            loadGrid(query);
        }

        private void loadGrid(string query) {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                SqlCommand cmd = new SqlCommand(query, connect);

                using (SqlDataReader reader = cmd.ExecuteReader()) {

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgTenant.DataSource = dt;

                    dgTenant.AllowUserToAddRows = false;

                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) { 
            
                DataGridViewRow selectedRow = dgTenant.Rows[e.RowIndex];

                string num1 = selectedRow.Cells["ID"].Value.ToString();

                tenantID = int.Parse(num1);

                loadTenant(tenantID);

            }
        }

        private void loadTenant(int ID) {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Select * from Tenant where Tenant_id = @tent_id";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@tent_id", ID);

                using (SqlDataReader reader = cmd.ExecuteReader()) {

                    while (reader.Read()) { 
                    
                    
                        txtFirstName.Text = reader["FirstName"].ToString();
                        txtLastName.Text = reader["LastName"].ToString();

                        txtContact.Text = reader["Contact"].ToString();
                        txtSchool.Text = reader["School"].ToString();

                        txtEmergencyName.Text = reader["Emergency_name"].ToString();
                        txtEmergeNumber.Text = reader["Emergency_contact"].ToString();

                        txtRelationship.Text = reader["Relationship"].ToString();
                        cmbGender.Text = reader["Gender"].ToString();
                        txtAddress.Text = reader["Address"].ToString();

                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Update Tenant set FirstName = @Fname, LastName = @LName, Gender = @gender, Contact = @contact," +
                    "Emergency_name = @emergeName, Emergency_contact = @emergeCon, Relationship = @relation, School = @school," +
                    "Address = @address, Document_pic = @docs where Tenant_id = @tnt_id";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {


                    byte[] imageData = null;
                    if (imgFilePath != null && imgFilePath != "")
                    {
                        using (FileStream fileStream = new FileStream(imgFilePath, FileMode.Open, FileAccess.Read))
                        {
                            imageData = new byte[fileStream.Length];
                            fileStream.Read(imageData, 0, imageData.Length);
                        }
                    }

                    cmd.Parameters.AddWithValue("@Fname", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@contact", long.Parse(txtContact.Text));
                    cmd.Parameters.AddWithValue("@emergeName", txtEmergencyName.Text);
                    cmd.Parameters.AddWithValue("@emergeCon", long.Parse(txtEmergeNumber.Text));
                    cmd.Parameters.AddWithValue("@relation", txtRelationship.Text);
                    cmd.Parameters.AddWithValue("@school", txtSchool.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@docs", imageData);
                    cmd.Parameters.AddWithValue("@tnt_id", tenantID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Update Success");

                    TenantManage_Load(sender, e);

                }
            }
            clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please Select Tenant To archive");
                return;

            }
            DialogResult result = MessageBox.Show("Do you want to Archive " + txtFirstName.Text + " " + txtLastName.Text 
                + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the result
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {

                    connect.Open();

                    string query = "Update Tenant set Archive = 1 where Tenant_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {

                        cmd.Parameters.AddWithValue("@id", tenantID);

                        cmd.ExecuteNonQuery();

                        using (SqlCommand cmd1 = new SqlCommand()) { 
                        
                        
                        
                        }

                            TenantManage_Load(sender, e);
                    }
                }
            }
            else
            {
                return;
            }
            clear();
        }

        private void cmbArchive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArchive.Text == "Default")
            {
                btnUpdate.Enabled = true;

                btnRestore.Visible = false;
                btnDel.Visible = true;

                TenantManage_Load(sender, e);

            }
            else {

                btnUpdate.Enabled = false;

                btnDel.Visible = false;
                btnRestore.Visible = true;

                string query = "Select \r\n    " +
                    "Tenant_id as ID,\r\n    " +
                    "FirstName + ' ' + LastName as Name,\r\n    " +
                    "Gender,\r\n    " +
                    "Contact,\r\n    " +
                    "Emergency_name,\r\n    " +
                    "Emergency_contact, \r\n    " +
                    "Relationship,\r\n    " +
                    "School,\r\n    " +
                    "Address\r\n" +
                    "from Tenant where Archive = 1";

                loadGrid(query); //function for showing datagrid from sql

            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to restore " + txtFirstName.Text + " " + txtLastName.Text
                + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the result
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {

                    connect.Open();

                    string query = "Update Tenant set Archive = 0 where Tenant_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {

                        cmd.Parameters.AddWithValue("@id", tenantID);

                        cmd.ExecuteNonQuery();

                        loadGrid("Select \r\n    " +
                    "Tenant_id as ID,\r\n    " +
                    "FirstName + ' ' + LastName as Name,\r\n    " +
                    "Gender,\r\n    " +
                    "Contact,\r\n    " +
                    "Emergency_name,\r\n    " +
                    "Emergency_contact, \r\n    " +
                    "Relationship,\r\n    " +
                    "School,\r\n    " +
                    "Address\r\n" +
                    "from Tenant where Archive = 1");
                    }
                }
            }
            else
            {
                return;
            }
            clear();
        }
        string imgFilePath = "";
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {

                //instance of Openfile dialog so I dont have to open filedialog on the designer
                OpenFileDialog ofdProfile = new OpenFileDialog();

                //this filters the file that profile picture can accept
                ofdProfile.Filter = "png files(*.png) | *.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

                //if the picture was selected it the filepath will be pass to the imgFilePath
                if (ofdProfile.ShowDialog() == DialogResult.OK)
                {
                    imgFilePath = ofdProfile.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewFileTenant vft = new ViewFileTenant();
            vft.ShowDialog();
        }

        void clear() {

            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtEmergencyName.Clear();
            txtEmergeNumber.Clear();
            txtRelationship.Clear();
            txtSchool.Clear();
            cmbGender.Text = "";
        
        }
    }
}
