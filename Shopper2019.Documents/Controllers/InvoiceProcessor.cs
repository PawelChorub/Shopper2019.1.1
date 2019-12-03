using Shopper2019.Documents.Models;
using Shopper2019.Documents.View;
using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper2019.Documents.Controllers
{
    public class InvoiceProcessor :IInvoiceProcessor /*IBuyer*/// IVendor
    {
        //public void InvoiceList(List<ISaleItem> list, IBuyer buyer, IVendor vendor, IInvoice invoice)
        //{
        //    InvoiceDocument i = new InvoiceDocument();

        //    i.InvoiceOrder(invoice);

        //    i.InvoiceVendor(vendor);

        //    i.InvoiceBuyer(buyer);

        //    i.InvoiceListData(list);

        //    i.Show();

        //}
        public void InvoiceListNew(List<ISaleItem> list, IBuyer buyer, IVendor vendor, IInvoice invoice)
        {
            InvoiceDocumentNew i = new InvoiceDocumentNew();

            //i.InvoiceOrder(invoice); // furtka do numeracji, po odczycie z bazy danych

            i. InvoiceVendor(vendor);

            i.InvoiceBuyer(buyer);

            i.InvoiceListData(list);

            i.Show();

        }
    }
}
