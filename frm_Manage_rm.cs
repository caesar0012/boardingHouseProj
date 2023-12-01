using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            //exampleDataGrid();

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmManage_rm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString) ) {

                connect.Open();

                String query = "SELECT cr1.room_number, cr1.Description, cr1.Capacity, cr1.Price,cpi.firstName + ' ' + cpi.middleName + ' ' + cpi.LastName AS Tenant, cr1.Status FROM Create_room as cr1 join Customer_Personal_Info as cpi on cpi.id = cr1.Room_id;";

                string example = "select number, description from manage_room";

                

            }
            //HEre lies

        }

        void exampleDataGrid() {

            gridRoom.Rows.Add("Al James", 45, "Deluxe", "King Size", 15000);
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add_room_frm a1 = new add_room_frm();
            a1.Show();
        }
    }
}
