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
    public partial class EditBedRoom : Form
    {
        public EditBedRoom()
        {
            InitializeComponent();
        }

        private void EditBedRoom_Load(object sender, EventArgs e)
        {

        }

        void loadData(string query) {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) { 
            
                connect.Open();

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
            
            
            }
        
        
        
        }

    }
}
