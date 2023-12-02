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
            
        }

        public static string roomNum= "";

        private void gridRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           /* try
            {

                // Check if the clicked cell is in the "clmnTenant" and is a button
                if (e.ColumnIndex == gridRoom.Columns["clmnRoom"].Index && e.RowIndex >= 0)
                {
                    // Get the value in a specific column of the clicked row
                    string roomNumber = gridRoom.Rows[e.RowIndex].Cells["clmnRoom"].Value.ToString();

                    roomNum = roomNumber;

                    MessageBox.Show($"Button clicked in row {e.RowIndex + 1}. Room Number: {roomNumber}");

                }
                else
                {

                    MessageBox.Show("Error: Invalid");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);

            }*/
        }

        private void gridRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            // Check if the clicked cell is not in the header row
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = gridRoom.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Check if the cell value is not null
                if (selectedCell.Value != null)
                {
                    // Select the entire row
                    gridRoom.Rows[e.RowIndex].Selected = true;

                    int columnIndex = gridRoom.Columns["clmnRoom"].Index;

                    string roomNumber = gridRoom.Rows[e.RowIndex].Cells["clmnRoom"].Value.ToString();
                    string Desc = gridRoom.Rows[e.RowIndex].Cells["clmnDesc"].Value.ToString();
                    string Capacity = gridRoom.Rows[e.RowIndex].Cells["clmnCapacity"].Value.ToString();
                    string Price = gridRoom.Rows[e.RowIndex].Cells["clmnRoom"].Value.ToString();



                    // Check if the column exists in the DataGridView
                    if (columnIndex != 0)
                    {
                        txtRoomNumber.Text = roomNumber;
                        txtDescription.Text = Desc;
                        txtCapacity.Text = Capacity;
                        txtPrice.Text = Price;
                    }
                    else
                    {
                        // Handle the case where the column does not exist
                        MessageBox.Show("Column not found.");
                    }
                }
            }


        }
    }
}
