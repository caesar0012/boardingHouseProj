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

            if (string.IsNullOrEmpty(txtName.Text))
            {

                MessageBox.Show("Please Enter Name");


            }
            else if (string.IsNullOrEmpty(txtContact.Text))
            {

                MessageBox.Show("Please Enter Contact");

            }
            else if (string.IsNullOrEmpty(txtRef.Text))
            {

                MessageBox.Show("Please Enter Reference");

            }
            else {

                DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Payment_Frm p1 = new Payment_Frm();

                    Payment_Frm.GName = txtName.Text;
                    Payment_Frm.Contact = long.Parse(txtContact.Text);
                    Payment_Frm.Reference = long.Parse(txtRef.Text);

                    this.Dispose();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
