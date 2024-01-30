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
                            where l1.lease_id is not null";
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

            }
        }
    }
}

//This is query for showing 
/*select

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
where l1.lease_id is not null*/