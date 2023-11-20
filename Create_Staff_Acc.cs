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
    public partial class Create_Staff_Acc : Form
    {
        public Create_Staff_Acc()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void frmCreateStaff_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {

                using (SqlConnection connection = new SqlConnection(ConnectSql.connectionString)) {
                    connection.Close();
                    connection.Open();
                        string userName, password;
                        




                    connection.Close();
                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }


    }
}
