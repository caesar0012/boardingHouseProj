using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            WindowState = FormWindowState.Maximized;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBig_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            showReservation();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            frmCreateStaff staff1 = new frmCreateStaff();
            staff1.TopLevel = false;
            staff1.Dock = DockStyle.Fill;
            panelMain.Controls.Add(staff1);
            staff1.BringToFront();
            staff1.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            showReservation();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
