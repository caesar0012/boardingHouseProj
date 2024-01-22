using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class loadBar : Form
    {
        public loadBar()
        {
            InitializeComponent();
        }

        private void timeLoad_Tick(object sender, EventArgs e)
        {
            pnlProgress.Width += 3;

            if (pnlProgress.Width >= pnlMain.Width)
            {
                timeLoad.Stop();

                frmLogin l1 = new frmLogin();
                l1.Show();
                this.Hide();
            }
        }

    }
}
