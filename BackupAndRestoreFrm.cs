using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardingHouseProj
{
    public partial class BackupAndRestoreFrm : Form
    {
        public BackupAndRestoreFrm()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string database = connect.Database.ToString();

                    string query = "Backup Database [" + database + "] To Disk= '" + "\\BoardingHouseDatabase" + "-" + DateTime.Now.ToString("yyyy-MM-HH") + ".bak'";
                    
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Backup Success");

            }
        }

        private void btnRestoreBrwse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Backup Files (*.bak)|*.bak";
            ofd.Title = "Database Restore";

            // edward @"C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\Backup";

            ofd.InitialDirectory = @"C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\Backup";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                txtRestore.Text = ofd.FileName;

                btnRestore.Enabled = true;

            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();
            
                string database = connect.Database.ToString();

                try
                {
                    // Step 1: Set the database to single user mode
                    string str1 = $"ALTER DATABASE [{database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    SqlCommand cmd1 = new SqlCommand(str1, connect);
                    cmd1.ExecuteNonQuery();

                    // Step 2: Use Master and restore the database
                    string str2 = $"USE master; RESTORE DATABASE [{database}] FROM DISK = '{txtRestore.Text}' WITH REPLACE";
                    SqlCommand cmd2 = new SqlCommand(str2, connect);
                    cmd2.ExecuteNonQuery();

                    // Step 3: Set the database back to multi-user mode
                    string str3 = $"ALTER DATABASE [{database}] SET MULTI_USER";
                    SqlCommand cmd3 = new SqlCommand(str3, connect);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Restore Done");
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during restore: " + ex.Message);
                    // Handle the exception as needed
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
    
}
