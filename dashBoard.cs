using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
        }

        int totalBed, availBed;

        void totalBed1() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "Select Count(assign_bed) as TotalBed from lease_tbl";

                string query1 = "Select SUM(Capacity) as TotalBed from Room";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    label7.Text = cmd.ExecuteScalar().ToString();

                    totalBed = int.Parse(label7.Text);

                }
                using (SqlCommand cmd1 = new SqlCommand(query1, connect)) { 
                    
                    string num1 = cmd1.ExecuteScalar().ToString(); 

                    int num2 = int.Parse(num1);

                    availBed = num2 - totalBed;

                    lblBeds.Text = availBed.ToString();
                    
                
                }


            }
        }

        void TotalRoom()
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "SELECT COUNT(DISTINCT Room_number) " +
                    "FROM Room where Archive = 0;";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    // Use ExecuteScalar to retrieve a single value
                    object result = cmd.ExecuteScalar();

                    // Check if the result is not null before converting to string
                    if (result != null)
                    {
                        lblRoom.Text = result.ToString();
                    }
                    else
                    {
                        // Handle the case where the result is null (no rooms found)
                        lblRoom.Text = "0";
                    }
                }
            }
        }

        void totalTenant()
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "Select count(lease_id) from lease_tbl\r\n    " +
                    "where room_id is not null and " +
                    "assign_bed is not null";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    // Use ExecuteScalar to retrieve a single value
                    object result = cmd.ExecuteScalar();

                    // Check if the result is not null before converting to string
                    if (result != null)
                    {
                        lblOccu.Text = result.ToString();
                    }
                    else
                    {
                        // Handle the case where the result is null (no rooms found)
                        lblOccu.Text = "0";
                    }
                }
            }
        }

        private void dashBoard_Load(object sender, EventArgs e)
        {
            TotalRoom();
            totalTenant();
            totalBed1();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
