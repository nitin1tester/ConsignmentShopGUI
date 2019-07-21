using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }

        public string display
        {
            get
            {
                return string.Format("{0} {1} due amount ${2}", FirstName, LastName,PaymentDue);
            }
        }
    }
}
