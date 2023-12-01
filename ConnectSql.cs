using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace boardingHouseProj
{
    internal class ConnectSql
    {
        //dapiton = @"Data Source=COLA\SQLEXPRESS;Initial Catalog=BoardingHouse;Integrated Security=True";

        public static string connectionString = @"Data Source=COLA\SQLEXPRESS;Initial Catalog=BoardingHouse;Integrated Security=True";

        static string edward = @"Data Source=DESKTOP-2GB3QJK\SQLEXPRESS01;Initial Catalog=BoardingHouse;Integrated Security=True";

        static string lenovo = @"Data Source=PC\SQLEXPRESS;Initial Catalog=BoardingHouse;Integrated Security=True";

        static string dapiton = @"Data Source=COLA\SQLEXPRESS;Initial Catalog=BoardingHouse;Integrated Security=True";

    }
}
