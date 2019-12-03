using Shopper2019.Documents.Controllers;
using Shopper2019.Documents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents
{
    public class Factory
    {
        public static IReceiptProcessor CreateReceiptProcessor()
        {
            return new ReceiptProcessor();
        }
        public static IReceipt CreateReceipt()
        {
            return new Receipt();
        }
        //-----------------FV
        public static IInvoice CreateInvoice()
        {
            return new Invoice();
        }
        public static IInvoiceProcessor CreateInvoiceProcessor()
        {
            return new InvoiceProcessor();
        }
        //--------------klient
        public static IBuyer CreateBuyer()
        {
            return new Buyer();
        }
        public static IVendor CreateVendor()
        {
            return new Vendor();
        }

    }
}
