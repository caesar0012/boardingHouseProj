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
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
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
            frmRoom fr1 = new frmRoom();
            fr1.TopLevel = false;
            fr1.FormBorderStyle = FormBorderStyle.None; // Optional to remove form border
            fr1.Dock = DockStyle.Fill; // Optional to fill the panel
            panelMain.Controls.Add(fr1);
            fr1.BringToFront();
            fr1.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
