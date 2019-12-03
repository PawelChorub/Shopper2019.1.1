using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.Models
{
    public class Invoice : IInvoice
    {
        public string Date { get; set; } = DateTime.Now.ToShortDateString();
        public int InvoiceNumber { get; set; } = 1;
        public string InvoiceNumberYear { get; set; } = DateTime.Now.Year.ToString();




    }
}
