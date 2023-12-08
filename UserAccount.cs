using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class UserAccount : Form
    {
        string imgFilePath = null;

        public UserAccount()
        {
            InitializeComponent();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
          
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
        private void ClearProfileInformation()
        {
            // Clear the displayed image and other profile information
            dpProfile.Image = null;
            // Clear other controls as needed
        }



        private void tbnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {


            
        }
    }
}
