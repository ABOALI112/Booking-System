using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public  class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; } = .5;
        public decimal PaymentDue { get; set; }

        public string Display
        {
            get
            {
                return $"{FirstName} , {LastName} ,{PaymentDue}";
            }
        }
    }
}
