using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.Models
{
    public class Buyer : IBuyer
    {
        public string BuyerName { get; set; }
        public string BuyerTaxNumber { get; set; }
        public string BuyerCity { get; set; }
        public string BuyerStreet { get; set; }
        public string BuyerPostCode { get; set; }
        public string BuyerStreetNumber { get; set; }
    }
}
