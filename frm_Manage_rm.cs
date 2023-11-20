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
    public partial class frmManage_rm : Form
    {
        public frmManage_rm()
        {
            InitializeComponent();
            exampleDataGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmManage_rm_Load(object sender, EventArgs e)
        {

        }

        void exampleDataGrid() {

            DataGridRoom.Rows.Add("Al James", 45, "Deluxe", "King Size", 15000);
            

        }
    }
}
