using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace boardingHouseProj
{
    public partial class room_tenant_add : Form
    {
        public room_tenant_add()
        {
            InitializeComponent();
            loadList();

            //Room number was taken from frmManage, a static string 
            lblRoomNumber.Text = frmManage_rm.roomNum;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //this method loads the list to the form
        private void loadList() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {
                connect.Open();

                string query = "Select * from Tenant";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {

                    using (SqlDataReader reader = cmd.ExecuteReader()) {

                        while (reader.Read()) {

                            cbNoRoomTenant.Items.Add(reader["FirstName"]);
                        
                        }
                    }      
                }
            }
        }
        //method for cheking the items
        private void CheckAllItems(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }
        }


        //method for uncheking the items
        private void UnCheckAllItems(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        //this is where the two method runs for uncheck and check all students
        private void cbSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelect.Checked)
            {//this checks all the checklist

                CheckAllItems(cbNoRoomTenant);

            }
            else { //Uncheck all the checklistBox

                UnCheckAllItems(cbNoRoomTenant);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {
                connect.Open();

                string query = "Update Tenant";

                using (SqlCommand cmd = new SqlCommand(query, connect)) { 
                
                
                }
            
            
            }
        }
    }
}
