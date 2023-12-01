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

                string query1 = "Select Room_number, Description, Availability, Price, Status from Room; ";

                SqlCommand cmd = new SqlCommand(query1, connect);

                int i = 0;

                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {

                        i++;

                        gridRoom.Rows.Add(i, reader["Room_number"], reader["Description"], reader["Availability"], reader["Price"], reader["Status"]);
                    
                    }
                    reader.Close();

                }
                

            }
            //HEre lies

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

        public static string roomNum= "";

        private void gridRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try {

                // Check if the clicked cell is in the "clmnTenant" and is a button
                if (e.ColumnIndex == gridRoom.Columns["clmnTenant"].Index && e.RowIndex >= 0)
                {
                    // Get the value in a specific column of the clicked row
                    string roomNumber = gridRoom.Rows[e.RowIndex].Cells["clmnRoom"].Value.ToString();

                    roomNum = roomNumber;

                    room_tenant_add r1 = new room_tenant_add();
                    r1.ShowDialog();

                }
                else {

                    MessageBox.Show("Error: Invalid");
            
                }

            }
            catch (Exception ex) {

                MessageBox.Show("Error:" + ex.Message);
            
            }
        }
    }
}
