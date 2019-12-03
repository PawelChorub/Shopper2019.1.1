using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.Models
{
    public class Receipt : IReceipt
    {
        public string ReceiptHeader { get; set; }
        public string DateAndTime { get; set; }
        public string ReceiptDetails { get; set; }
        public string ReceiptFooter { get; set; }
    }
}
