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

        bool drag = false;
        Point start_point = new Point(0,0);

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
            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectSql.connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Employee_acc WHERE Employee_id = @emp_id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@emp_id", frmLogin.employee_id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (int.TryParse(reader["Employee_id"].ToString(), out int employeeId))
                                {
                                    frmLogin.employee_id = employeeId;
                                }

                                byte[] img = reader["ProfilePic"] as byte[];

                                if (img == null)
                                {
                                    profileMain.Image = null;
                                }
                                else
                                {
                                    using (MemoryStream ms = new MemoryStream(img))
                                    {
                                        profileMain.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., log or display an error message)
                MessageBox.Show($"Error loading profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmManage_rm rm1 = new frmManage_rm();
            rm1.TopLevel = false;
            rm1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            rm1.Dock = DockStyle.Fill; // Optional to fill the panel
            panelMain.Controls.Add(rm1);
            rm1.BringToFront();
            rm1.Show();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            frmCustomer c1 = new frmCustomer();
            c1.TopLevel = false;
            c1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            c1.Dock = DockStyle.Fill; // Optional to fill the panel
            panelMain.Controls.Add(c1);
            c1.BringToFront();
            c1.Show();
        }

        private void profileMain_Click(object sender, EventArgs e)
        {
            UserSettings u1 = new UserSettings();

            u1.TopLevel = false;
            u1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            u1.Dock = DockStyle.Fill; // Optional to fill the panel
            panelMain.Controls.Add(u1);
            u1.BringToFront();
            u1.Show();

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashBoard d1 = new dashBoard();

            d1.TopLevel = false;
            d1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            d1.Dock = DockStyle.Fill; // Optional to fill the panel
            panelMain.Controls.Add(d1);
            d1.BringToFront();
            d1.Show();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);

            }
        }
    }
}
