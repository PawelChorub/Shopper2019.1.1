using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.Models
{
    public class Vendor : IVendor
    {
        public string Name { get; set; } = "Podmiot sprzedający";
        public string TaxNumber { get; set; } = "987-654-32-11";
        public string City { get; set; } = "Częstochowa";
        public string Street { get; set; } = "Dziurawa";
        public string PostCode { get; set; } = "42-202";
        public string StreetNumber { get; set; } = "28";
        //public string Name { get; set; }
        //public string TaxNumber { get; set; }
        //public string City { get; set; }
        //public string Street { get; set; }
        //public string PostCode { get; set; }
        //public string StreetNumber { get; set; }
    }
}
