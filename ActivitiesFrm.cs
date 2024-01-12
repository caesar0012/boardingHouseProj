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
    public partial class ActivitiesFrm : Form
    {
        public ActivitiesFrm()
        {
            InitializeComponent();
            // Set default cell style font
            dgAct.DefaultCellStyle.Font = new Font("Arial", 12);

            // Set column header font
            dgAct.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }
        private void ActivitiesFrm_Load(object sender, EventArgs e)
        {   
            filterLoad("Select \r\n\t" +
                "s1.Staff_id,\r\n\t" +
                "s1.FirstName + ' ' + s1.LastName as Staff,\r\n\t" +
                "r1.Room_number,\r\n\t" +
                "r1.Description\r\n" +
                "from Staff_acc as s1\r\n" +
                "left join Room as r1\r\n" +
                "on s1.Staff_id = r1.Staff_id\r\n" +
                "where r1.Room_id is not null\r\n" +
                "order by s1.FirstName + ' ' + s1.Lastname");
        }

        private void dgAct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void filterLoad(string query) {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) { 
            
                connect.Open();

                SqlCommand cmd = new SqlCommand(query, connect);

                using (SqlDataReader reader = cmd.ExecuteReader()) { 
                
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgAct.DataSource = dt;
                
                }
                dgAct.AllowUserToAddRows = false;

            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "Room") {

                ActivitiesFrm_Load(sender, e);

            } else if (cmbFilter.Text == "Lease") {

                filterLoad("SELECT\r\n\t" +
                    "s1.Staff_id,\r\n\t" +
                    "s1.FirstName + ' ' + s1.LastName as Staff,\r\n\t" +
                    "t1.FirstName + ' ' + t1.LastName as Tenant,\r\n\t" +
                    "l1.Room_id,\r\n\t" +
                    "l1.assign_bed\r\n" +
                    "from Staff_acc as s1\r\n" +
                    "left join lease_tbl as l1\r\n" +
                    "on s1.Staff_id = l1.Staff_id\r\n" +
                    "left join Tenant as t1\r\n" +
                    "on t1.Tenant_id = l1.Tenant_id\r\n" +
                    "where l1.lease_id is not null and t1.archive = 0");

                dgAct.Refresh();


            } else if (cmbFilter.Text == "Payment") {

                filterLoad("Select \r\n\t" +
                    "s1.Staff_id,\r\n\t" +
                    "s1.FirstName + ' ' + s1.LastName as Staff,\r\n\t" +
                    "l1.lease_id,\r\n\t" +
                    "p1.Amount_paid as Amount,\r\n\t" +
                    "p1.PaymentDate as Date\r\n" +
                    "from Staff_acc as s1\r\n" +
                    "left join Payment as p1\r\n" +
                    "on p1.Staff_id = s1.Staff_id\r\n" +
                    "LEFT join lease_tbl as l1\r\n" +
                    "on l1.lease_id = p1.Lease_id\r\n" +
                    "where l1.lease_id is not null and p1.PaymentDate is not null");

                dgAct.Refresh();


            }
            else if (cmbFilter.Text == "Addon")
            {
                filterLoad("Select \r\n\t" +
                    "S1.Staff_id,\r\n\t" +
                    "s1.FirstName + ' ' + s1.LastName as 'Staff',\r\n\t" +
                    "a1.AddOnDetails as Detail,\r\n\t" +
                    "a1.AddOnAmount as Amount,\r\n\t" +
                    "a1.Date\r\n" +
                    "From Staff_acc as s1\r\n" +
                    "LEFT join Addon as a1\r\n" +
                    "on s1.Staff_id = a1.Staff_id\r\n" +
                    "where a1.Addon_id is not null and a1.Archive = 0");

                dgAct.Refresh();


            }
            else if (cmbFilter.Text == "Maintenance")
            {
                filterLoad("SELECT \r\n    " +
                    "s1.Staff_id,\r\n    " +
                    "s1.FirstName + ' ' + s1.LastName AS Staff,\r\n    " +
                    "m1.Details,\r\n    " +
                    "CONVERT(DATE, m1.Date_added) AS Date\r\n" +
                    "FROM \r\n    " +
                    "Staff_acc AS s1\r\n" +
                    "LEFT JOIN \r\n    " +
                    "Maintenance AS m1 ON s1.Staff_id = m1.Staff_id\r\n" +
                    "WHERE \r\n    " +
                    "m1.Maintenance_id IS NOT NULL AND m1.Archive = 0;");

                dgAct.Refresh(); ;


            }
            else if (cmbFilter.Text == "Tenant Request")
            {
                filterLoad("SELECT \r\n    " +
                    "s1.FirstName + ' ' + s1.LastName AS Staff,\r\n\t" +
                    "t1.FirstName + ' ' + t1.LastName as Tenant,\r\n\t" +
                    "r1.Details,\r\n\t" +
                    "CONVERT(Date, r1.Date_added) as Date\r\n" +
                    "from Staff_acc as s1\r\n" +
                    "LEFT join TenantRequest as r1\r\n" +
                    "on r1.Staff_id = s1.Staff_id\r\n" +
                    "left join Tenant as t1\r\n" +
                    "on r1.Tenant_id = t1.Tenant_id\r\n" +
                    "where r1.Archive = 0 and r1.Request_id is not null");

                dgAct.Refresh();

            }
        }

        
    }
}
