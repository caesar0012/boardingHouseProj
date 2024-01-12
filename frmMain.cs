using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            roleCheck();
        }

        void roleCheck() {

            if (btnSee.role == "Admin") {



            } else if (btnSee.role == "Manager") {

                flpAdmin.Hide();
                btnManageStaff.Hide();

            }
            else if (btnSee.role == "Cashier")
            {

                flpAdmin.Hide();
                flpRoom.Hide();
                flpStaff.Hide();
                flpTenant.Hide();
                
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }
        private void LoadProfile() //
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectSql.connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Staff_acc WHERE Staff_id = @Staff_id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Staff_id", btnSee.staff_id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assign the value from the reader to frmLogin.staff_id
                                btnSee.staff_id = reader["Staff_id"].ToString();

                                byte[] img = reader["ProfilePic"] as byte[];

                                if (img == null)
                                {
                                    
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

        private Form activeForm = null;

        private void OpenForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void profileMain_Click(object sender, EventArgs e)
        {
            OpenForm(new UserSettings());
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
            OpenForm(new dashBoard());
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {

            TimeRoom.Start();
            timeNavi.Start();

            OpenForm(new room_tenant_add());
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            OpenForm(new frmManage_rm());

            TimeRoom.Start();
            timeNavi.Start();
        }

        private void btnCreateTenant_Click(object sender, EventArgs e)
        {
            OpenForm(new frmCustomer());

            TimeTenant.Start();
            timeNavi.Start();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            
            OpenForm(new Create_Staff_Acc());

            TimeStaff.Start();
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
            b1.Show();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            OpenForm(new ManageStaffFrm());

            TimeStaff.Start();
            timeNavi.Start();
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            OpenForm(new ActivitiesFrm());

            TimeAdmin.Start();
            timeNavi.Start();
        }

        private void btnManageTenant_Click_1(object sender, EventArgs e)
        {
            OpenForm(new EditTenantFrm());

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
            OpenForm(new Payment_Frm());
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            btnSee l1 = new btnSee();
            l1.ShowDialog();
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
    }
}
    