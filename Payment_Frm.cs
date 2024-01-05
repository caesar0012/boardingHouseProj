using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class Payment_Frm : Form
    {
        private object e;

        public Payment_Frm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Payment_Frm_Load(object sender, EventArgs e)
        {
            FilterLoad("Select\r\n\t" +
                "t1.Tenant_id,\r\n\t" +
                "t1.FirstName + ' ' + t1.LastName as Name,\r\n\t" +
                "t1.Gender,\r\n\t" +
                "r1.Room_number,\r\n\t" +
                "l1.assign_bed, l1.MonthlyPayment as Rent\r\n" +
                "From Tenant as t1\r\n" +
                "left join lease_tbl as l1\r\n" +
                "on t1.Tenant_id = l1.Tenant_id\r\n" +
                "left join Room as r1\r\n" +
                "on l1.room_id = r1.Room_id\r\n" +
                "left join Payment as p1\r\n" +
                "on l1.Tenant_id = t1.Tenant_id\r\n" +
                "group by\r\n" +
                "t1.Tenant_id, t1.FirstName, t1.LastName, t1.Gender, r1.Room_number, l1.assign_bed, l1.MonthlyPayment;");

            //loadListBox();

        }

        private void FilterLoad(string query)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        DataTable dt = new DataTable();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Load the entire result set into the DataTable
                            dt.Load(reader);
                        }

                        dgPayment.DataSource = dt;
                    }
                }
            }
            catch {

                MessageBox.Show("Datagrid failed to load");
            
            }
        }

        private void dgPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgPayment.Rows[e.RowIndex];

            selectedRow.Selected = true;

       //     string tent_id = selectedRow.Cells["Tenant_id"].Value?.ToString();


        }

        private void dgPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >=0) {

                DataGridViewRow selectedRow = dgPayment.Rows[e.RowIndex];
                selectedRow.Selected = true;

             //   txtTenant_id.Text = selectedRow.Cells["Tenant_id"].Value?.ToString();
                txtTenantName.Text = selectedRow.Cells["Name"].Value?.ToString();
                txtRent.Text = selectedRow.Cells["Rent"].Value?.ToString();


                //txtDetailsAddon.Text = selectedRow.Cells["Rent"].Value?.ToString();
                // txtAddOnsPrice.Text = selectedRow.Cells["Rent"].Value?.ToString();


                //loadListBox();

                
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtTenantName.Text)) {

                    MessageBox.Show("Please Select Tenant Name");

                } else if (string.IsNullOrEmpty(txtPayable.Text)) {

                    MessageBox.Show("Please Insert Payment Amount");

                }
                else
                {

                    if (cmbPaymentType.Text == "GCash") {

                        gcashPayment();
                        updateAddOn();

                    } else if (cmbPaymentType.Text == "Cash") {

                        PaymentInsert();
                        updateAddOn();
                    }
                    else
                    {

                        MessageBox.Show("Please Select Payment Type");
                        return;

                    }
                }
            }
            else
            {
                // User clicked No
                // Perform the action you want when the user chooses No
            }

        }


        private void PaymentInsert() {


            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {

                connect.Open();

                int setLease = getLease_id();

                string query = "Insert into Payment(staff_id, lease_id, Amount_paid, Payment_type)values" +
                    "(@staff_id, @leaseID, @AmountPaid, @PaymentType)";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    cmd.Parameters.AddWithValue("@staff_id", frmLogin.staff_id);
                    cmd.Parameters.AddWithValue("@leaseID", setLease);
                    cmd.Parameters.AddWithValue("@AmountPaid", double.Parse(txtPayable.Text));
                    cmd.Parameters.AddWithValue("@PaymentType", cmbPaymentType.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Transaction Success");
                }
            }
        }

        private void gcashPayment()
        {
          /*  if (string.IsNullOrEmpty(txtName.Text)) {

                MessageBox.Show("Please Insert Name");

            } else if (string.IsNullOrEmpty(txtContact.Text)) {

                MessageBox.Show("Please Insert Contact No");

            }
            else if (string.IsNullOrEmpty(txtRef.Text))
            {

                MessageBox.Show("Please Insert reference");

            }
            else
            {
                try {

                    using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                    {

                        connect.Open();

                        int setLease = getLease_id();

                        string query = "Insert into Payment(staff_id, lease_id, Amount_paid, Payment_type, SenderName, Contact, Reference)values" +
                            "(@staff_id, @leaseID, @AmountPaid, @PaymentType, @SName, @contactNo, @Reference)";

                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {

                            cmd.Parameters.AddWithValue("@staff_id", frmLogin.staff_id);
                            cmd.Parameters.AddWithValue("@leaseID", setLease);
                            cmd.Parameters.AddWithValue("@AmountPaid", double.Parse(txtPayable.Text));
                            cmd.Parameters.AddWithValue("@PaymentType", cmbPaymentType.Text);
                            cmd.Parameters.AddWithValue("@SName", txtName.Text);
                            cmd.Parameters.AddWithValue("@contactNo", long.Parse(txtContact.Text));
                            cmd.Parameters.AddWithValue("@Reference", long.Parse(txtRef.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Transaction Success");
                        }
                    }

                }
                catch (Exception ex) {

                    MessageBox.Show("Error Insert Gcash" + ex.Message);
                
                }
            
            }*/

            
        }

        private void updateAddOn() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                string query = "Update Addon set Archive = 1\r\n" +
                    "where AddOnDetails = @details and lease_id = @ID";

                connect.Open();

                int ID = getLease_id();

                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    foreach (string item in clbAddOns.CheckedItems) {

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@details", item);
                        cmd.Parameters.AddWithValue("@ID", ID);

                        cmd.ExecuteNonQuery();

                    }
                }
            }
        }



       private int getLease_id() { //The use of the method is for the insert rows of the Payment Table 

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Select \r\n\t" +
                    "l1.Lease_id\r\n" +
                    "from Tenant as t1\r\n" +
                    "left join lease_tbl as l1\r\n" +
                    "on t1.Tenant_id = l1.Tenant_id\r\n" +
                    "where l1.lease_id is not null and t1.archive = 0 and t1.FirstName + ' ' + t1.LastName = @name";

                SqlCommand cmd = new SqlCommand(query, connect);

                
                    cmd.Parameters.AddWithValue("@name", txtTenantName.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming Room_id is of type int, use GetInt32 instead of GetString
                            return reader.GetInt32(0); // Use index 0 for Room_id
                        }
                    }
                
            }
            return 0;
        }

        private void loadListBox() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {

                connect.Open();

                string query = "Select \r\n\t" +
                    "a1.AddOnDetails,\r\n\t" +
                    "a1.AddonAmount\r\n" +
                    "from Addon as a1\r\n" +
                    "left join lease_tbl as l1\r\n" +
                    "on l1.lease_id = a1.lease_id\r\n" +
                    "where l1.lease_id = @leaseId and a1.Archive = 0";

                int ID = getLease_id();

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@leaseId", ID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    clbAddOns.Items.Clear();

                    while (reader.Read())
                    {
                        clbAddOns.Items.Add(reader["AddOnDetails"]);

                    }

                }
            }

        }

        private void txtTenantName_TextChanged(object sender, EventArgs e)
        {
            label2.Text = getLease_id().ToString();
            loadListBox();
        }

        private void clbAddOns_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtTotal.Text = TotalPay().ToString();

        }

        private double TotalPay() {

            try
            {
                double num1 = 0;

                num1 = double.Parse(txtRent.Text);

                return num1 + calculateTotalCheck();
            }
            catch {

                return calculateTotalCheck();
            
            }

        }

        private double calculateTotalCheck()
        {
            double totalAmount = 0.0;

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "SELECT a1.AddonAmount " +
                               "FROM Addon AS a1 " +
                               "LEFT JOIN lease_tbl AS l1 " +
                               "ON l1.lease_id = a1.lease_id " +
                               "WHERE l1.lease_id = @leaseID AND a1.AddOnDetails = @Details";

                int ID = getLease_id();

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    foreach (string item in clbAddOns.CheckedItems)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@leaseID", ID);
                        cmd.Parameters.AddWithValue("@Details", item);

                        object result = cmd.ExecuteScalar();

                        if (result != null && double.TryParse(result.ToString(), out double price))
                        {
                            totalAmount += price;
                        }
                        else
                        {
                            // Handle the case where the AddonAmount is not a valid double
                            Console.WriteLine($"Invalid AddonAmount for item {item}");
                        }
                    }
                }
            }

            // Output the total sum before returning
            Console.WriteLine($"Total sum of AddonAmount values: {totalAmount}");

            return totalAmount;
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = TotalPay().ToString();
        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentType.Text == "GCash")
            {
                GcashForm g1 = new GcashForm();
                g1.ShowDialog();
                

            }
            else {

                //do nothing
                return;

            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered character is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit, suppress the keypress event
                e.Handled = true;
            }
        }

        private void btnAddOn_Click(object sender, EventArgs e)
        {
            AddOnFrm a1 = new AddOnFrm();

            a1.Show();
        }

        public static string Name;

        private void button1_Click(object sender, EventArgs e)
        {
            txtReceived.Text = this.Name;
        }
    }
}
