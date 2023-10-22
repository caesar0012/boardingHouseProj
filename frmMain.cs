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

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string colorMain = "#" + txtBg.Text;

            Color selectedColor = ColorTranslator.FromHtml(colorMain);

            panelMain.BackColor= selectedColor;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            string colorMain2 = "#" + txtPanel.Text;

            Color selectedColor2 = ColorTranslator.FromHtml(colorMain2);

            panel1.BackColor = selectedColor2;
            panel2.BackColor = selectedColor2;

        }
    }
}
