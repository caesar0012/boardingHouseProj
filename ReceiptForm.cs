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

        private void ReceiptForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReportDataSource rcInfo = new ReportDataSource("DataSet1", ReceiptInfo());
            reportViewer1.LocalReport.DataSources.Add(rcInfo);
        }

        private DataTable ReceiptInfo()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString))
                {
                    connect.Open();

                    string query = "SELECT * FROM receiptView WHERE Payment_id = 1";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
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

    }
}
