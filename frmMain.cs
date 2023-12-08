using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();          
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadProfile();
        }

        private void loadProfile() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {

                connect.Open();

                string query = "Select * from Employee_acc where Employee_id = @emp_id";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@emp_id", frmLogin.employee_id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        if (int.TryParse(reader[0].ToString(), out int intNumValue))
                        {
                            frmLogin.employee_id = intNumValue;
                        }

                        byte[] img = (byte[])(reader["ProfilePic"]);

                        if (img == null)
                        {

                            profileMain.Image = null;

                        }
                        else
                        {

                            MemoryStream ms = new MemoryStream(img);
                            profileMain.Image = Image.FromStream(ms);

                        }
                    }
                }

            }



        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Create_Staff_Acc staff1 = new Create_Staff_Acc();
            staff1.TopLevel = false;
            staff1.Dock = DockStyle.Fill;
            panelMain.Controls.Add(staff1);
            staff1.BringToFront();
            staff1.Show();
        }

        void showReservation() {

            frmCustomer c1 = new frmCustomer();
            c1.TopLevel = false;
            c1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            c1.Dock = DockStyle.Fill; // Optional to fill the panel
            panelMain.Controls.Add(c1);
            c1.BringToFront();
            c1.Show();

        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profileMain_Click(object sender, EventArgs e)
        {

        }



    }
}
