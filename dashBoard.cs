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

                string query = "SELECT COUNT(DISTINCT Tenant_id) " +
                    "FROM Tenant where Archive = 0;";

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
        }

        private void cmbEarning_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEarning.Text == "Month")
            {

                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    string query = "SELECT ISNULL(SUM(amount_paid), 0) AS TotalAmountPaid\r\nFROM Payment\r\nWHERE YEAR(PaymentDate) = YEAR(GETDATE());\r\n";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Use ExecuteScalar to retrieve a single value
                        object result = cmd.ExecuteScalar();

                        // Check if the result is not null before converting to string
                        if (result != null)
                        {
                            lblEarnings.Text = result.ToString();
                        }
                        else
                        {
                            // Handle the case where the result is null (no rooms found)
                            lblEarnings.Text = "0";
                        }
                    }
                }
            }
            else {

                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    string query = "SELECT ISNULL(SUM(amount_paid), 0) AS TotalAmountPaid " +
                       "FROM Payment " +
                       "WHERE Month(PaymentDate) = Month(GETDATE());";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Use ExecuteScalar to retrieve a single value
                        object result = cmd.ExecuteScalar();

                        // Check if the result is not null before converting to string
                        if (result != null)
                        {
                            lblEarnings.Text = result.ToString();
                        }
                        else
                        {
                            // Handle the case where the result is null (no rooms found)
                            lblEarnings.Text = "0";
                        }
                    }
                }
            }
        }
    }
}
