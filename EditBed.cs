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
    public partial class EditBed : Form
    {
        public EditBed()
        {
            InitializeComponent();
        }

        private void EditBed_Load(object sender, EventArgs e)
        {
            string query = "Select * from Room";
            loadData(query);
        }

        private void loadData(string query) {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                SqlCommand cmd = new SqlCommand(query, connect);

                SqlDataReader read = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(read);
                dgBed.DataSource = dt;
                

            }
        }

        private void dgBed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow selectedRow = dgBed.Rows[e.RowIndex];
                selectedRow.Selected = true;

                txtID.Text = selectedRow.Cells["Room_id"].Value.ToString();

            }
        }
    }
}
