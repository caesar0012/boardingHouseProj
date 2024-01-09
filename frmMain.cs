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
        Point start_point = new Point(0, 0);

        bool menuExpand, TenantCollapse, StaffCollapse, roomClps, AdminCollpse;

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

                    string query = "SELECT * FROM Staff_acc WHERE Staff_id = @Staff_id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Staff_id", frmLogin.staff_id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (int.TryParse(reader["Staff_id"].ToString(), out int Staff_id))
                                {
                                    frmLogin.staff_id = Staff_id;
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




        private void profileMain_Click(object sender, EventArgs e)
        {
            UserSettings u1 = new UserSettings();

            u1.TopLevel = false;
            u1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            u1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(u1);
            u1.BringToFront();
            u1.Show();
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

        private void btnShowTenant_Click(object sender, EventArgs e)
        {
            TimeTenant.Start();
            timeNavi.Start();
        }

        private void TimeTenant_Tick(object sender, EventArgs e)
        {
            int change = TenantCollapse ? -10 : 10;

            flpTenant.Height += change;

            if ((TenantCollapse && flpTenant.Height <= flpTenant.MinimumSize.Height) ||
                (!TenantCollapse && flpTenant.Height >= flpTenant.MaximumSize.Height))
            {
                TenantCollapse = !TenantCollapse;
                TimeTenant.Stop();
            }
        }

        private void btnShowRoom_Click(object sender, EventArgs e)
        {
            TimeRoom.Start();
            timeNavi.Start();
        }

        private void TimeRoom_Tick(object sender, EventArgs e)
        {
            int change = roomClps ? -10 : 10;

            flpRoom.Height += change;

            if ((roomClps && flpRoom.Height <= flpRoom.MinimumSize.Height) ||
                (!roomClps && flpRoom.Height >= flpRoom.MaximumSize.Height))
            {
                roomClps = !roomClps;
                TimeRoom.Stop();
            }
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            TimeStaff.Start();
            timeNavi.Start();

        }

        private void TimeStaff_Tick(object sender, EventArgs e)
        {
            int change = StaffCollapse ? -10 : 10;

            flpStaff.Height += change;

            if ((StaffCollapse && flpStaff.Height <= flpStaff.MinimumSize.Height) ||
                (!StaffCollapse && flpStaff.Height >= flpStaff.MaximumSize.Height))
            {
                StaffCollapse = !StaffCollapse;
                TimeStaff.Stop();
            }
        }

        private void btnDashBoard_Click_1(object sender, EventArgs e)
        {
            dashBoard d1 = new dashBoard();

            d1.TopLevel = false;
            d1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(d1);
            d1.BringToFront();
            d1.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {

            TimeRoom.Start();
            timeNavi.Start();

            room_tenant_add r1 = new room_tenant_add();
            r1.TopLevel = false;
            r1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            r1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(r1);
            r1.BringToFront();
            r1.Show();
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            frmManage_rm rm1 = new frmManage_rm();
            rm1.TopLevel = false;
            rm1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            rm1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(rm1);
            rm1.BringToFront();
            rm1.Show();

            TimeRoom.Start();
            timeNavi.Start();
        }

        private void btnCreateTenant_Click(object sender, EventArgs e)
        {

            frmCustomer c1 = new frmCustomer();
            c1.TopLevel = false;
            c1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            c1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(c1);
            c1.BringToFront();
            c1.Show();

            TimeTenant.Start();
            timeNavi.Start();

        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            Create_Staff_Acc staff1 = new Create_Staff_Acc();
            staff1.TopLevel = false;
            staff1.Dock = DockStyle.Fill;
            this.Controls.Add(staff1);
            staff1.BringToFront();
            staff1.Show();

            TimeStaff.Start();
            timeNavi.Start();
        }

        private void btnManageTenant_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment_Frm p1 = new Payment_Frm();
            p1.TopLevel = false;
            p1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            p1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(p1);
            p1.BringToFront();
            p1.Show();

            TimeTenant.Start();
            timeNavi.Start();

        }

        private void btnShowAdmin_Click(object sender, EventArgs e)
        {
            TimeAdmin.Start();
            timeNavi.Start();
        }

        private void btnBackReco_Click(object sender, EventArgs e)
        {
            TimeAdmin.Start();
            timeNavi.Start();
            BackupAndRestoreFrm b1 = new BackupAndRestoreFrm();
            this.Hide();
            b1.Show();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            ManageStaffFrm m1 = new ManageStaffFrm();
            m1.TopLevel = false;
            m1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            m1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(m1);
            m1.BringToFront();
            m1.Show();

            TimeStaff.Start();
            timeNavi.Start();
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            ActivitiesFrm a1 = new ActivitiesFrm();

            a1.TopLevel = false;
            a1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            a1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(a1);
            a1.BringToFront();
            a1.Show();

            TimeAdmin.Start();
            timeNavi.Start();
        }

        private void btnManageTenant_Click_1(object sender, EventArgs e)
        {
            EditTenantFrm e1 = new EditTenantFrm();

            e1.TopLevel = false;
            e1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            e1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(e1);
            e1.BringToFront();
            e1.Show();

            TimeTenant.Start();
            timeNavi.Start();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnLoad_Click(sender, e);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Payment_Frm e1 = new Payment_Frm();

            e1.TopLevel = false;
            e1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            e1.Dock = DockStyle.Fill; // Optional to fill the panel
            this.Controls.Add(e1);
            e1.BringToFront();
            e1.Show();

        }

        private void TimeAdmin_Tick(object sender, EventArgs e)
        {
            int change = AdminCollpse ? -10 : 10;

            flpAdmin.Height += change;

            if ((AdminCollpse && flpAdmin.Height <= flpAdmin.MinimumSize.Height) ||
                (!AdminCollpse && flpAdmin.Height >= flpAdmin.MaximumSize.Height))
            {
                AdminCollpse = !AdminCollpse;
                TimeAdmin.Stop();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);

            }
        }

        private void timeNavi_Tick(object sender, EventArgs e)
        {
            const int StepSize = 10;

            if (menuExpand)
            {
                flpMain.Width -= StepSize;
            }
            else
            {
                flpMain.Width += StepSize;
            }

            bool isAtMinimumSize = (flpMain.Width == flpMain.MinimumSize.Width);
            bool isAtMaximumSize = (flpMain.Width == flpMain.MaximumSize.Width);

            if (isAtMinimumSize || isAtMaximumSize)
            {
                menuExpand = !menuExpand;
                timeNavi.Stop();
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timeNavi.Start();
        }
    }
}
    