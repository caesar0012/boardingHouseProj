using Microsoft.Reporting.WinForms;
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
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();

        }
        public static int numRow = 2;

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReportDataSource rcInfo = new ReportDataSource("DataSet1", ReceiptInfo(numRow));
            reportViewer1.LocalReport.DataSources.Add(rcInfo);
        }

        private DataTable ReceiptInfo(int paymentId)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    string query = "SELECT * FROM receiptView WHERE Payment_id = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@ID", paymentId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if the reader has rows before loading data
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                            else
                            {
                                // Handle the case where no rows are returned
                                // You may want to log or throw an exception
                                // For now, we'll just print a message
                                Console.WriteLine("No rows found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during database operations
                // You may want to log or rethrow the exception
                Console.WriteLine($"Error: {ex.Message}");
            }

            return dt;
        }

        private int takeLastRow()
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
            {
                connect.Open();

                string query = "SELECT TOP 1 Payment_id FROM Payment ORDER BY Payment_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);

                    }

                    // If no rows were returned, handle it accordingly
                    return 0;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
