using System.Collections.Generic;
using Shopper2019.Documents.Models;
using Shopper2019.Logic.Models;

namespace Shopper2019.Documents.Controllers
{
    public interface IInvoiceProcessor
    {
        //void InvoiceList(List<ISaleItem> list, IBuyer buyer, IVendor vendor, IInvoice invoice);
        void InvoiceListNew(List<ISaleItem> list, IBuyer buyer, IVendor vendor, IInvoice invoice);
    }
}