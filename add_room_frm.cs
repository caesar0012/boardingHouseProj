using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace boardingHouseProj
{
    public partial class add_room_frm : Form
    {
        public add_room_frm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Close();
                connect.Open();

                int room_number = int.Parse(txtRoomNumber.Text);
                string description = txtDescription.Text;
                int capacity = int.Parse(txtCapacity.Text);
                double price = double.Parse((txtPrice.Text));
                string status = "Available";

                string query = "Insert into Room(Room_number, Description, Availability, Capacity, Price, Status) values " +
                    "(@Room_number, @Description, @Availability, @Capacity, @Price, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    cmd.Parameters.AddWithValue("@Room_number", room_number);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Availability", capacity);
                    cmd.Parameters.AddWithValue("@Capacity", capacity);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Status", status);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Room Added successfully");

                    connect.Close();

                }

            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_room_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
