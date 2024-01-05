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
    public partial class GcashForm : Form
    {
        public GcashForm()
        {
            InitializeComponent();
        }

        private void GcashForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Payment_Frm p1 = new Payment_Frm();
            
            Payment_Frm.Name = txtName.Text;


            this.Hide();
        }
    }
}
