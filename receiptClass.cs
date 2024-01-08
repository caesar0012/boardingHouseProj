using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boardingHouseProj
{
    internal class receiptClass
    {

        public int ID { get; set; }
        public string StaffName { get; set; }

        public double total { get; set; }

        public string tenantName { get; set; }

        public double paymentReceive {  get; set; }
        public double change { get; set; }


    }
}
