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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

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
            string query = @"select
                    b1.bed_id,
                    b1.BedNumber,
                    t1.FirstName + ' ' + t1.LastName as Name,
                    l1.StartLease,
                    l1.EndLease,
                    b1.status as Status
                from bed_tbl as b1
                left join lease_tbl as l1
                on  b1.bed_id = l1.bed_id
                left join Tenant as t1
                on l1.Tenant_id = t1.Tenant_id
                left join Room as r1
                on b1.RoomID = r1.Room_id
                where l1.lease_id is not null and r1.Room_number = '" + frmManage_rm.roomNum + "'";
            ;

            loadData(query);
            loadTenant();
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
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    DataGridViewRow selectedRow = dgBed.Rows[e.RowIndex];
                    selectedRow.Selected = true;

                    txtBed.Text = selectedRow.Cells["BedNumber"].Value.ToString();
                    cmbTenant.Text = selectedRow.Cells["Name"].Value.ToString();
                    cmbBedStats.Text = selectedRow.Cells["Status"].Value.ToString();
                }
            }
            catch { 
            
            
            }
        }

        void updateBed() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = "";

                SqlCommand cmd = new SqlCommand(query, connect);



                cmd.ExecuteNonQuery();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        void loadTenant() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {

                connect.Open();

                string query = @"SELECT
                                    t1.FirstName + ' ' + t1.LastName as Name
                                from Tenant as t1
                                left JOIN lease_tbl as l1
                                on t1.Tenant_id = l1.Tenant_id 
                                where t1.archive = 0 and l1.bed_id is NULL";

                SqlCommand cmd = new SqlCommand(query, connect);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {

                    cmbTenant.Items.Add(reader["Name"]);
                }
            }
        }
    }
}
