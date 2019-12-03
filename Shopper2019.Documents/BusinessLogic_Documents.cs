using Shopper2019.Documents.Controllers;
using Shopper2019.Documents.Models;
using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents
{
    public class BusinessLogic_Documents : IBusinessLogic_Documents
    {

        IReceiptProcessor rp = Factory.CreateReceiptProcessor();

        public void ReceiptDetailsBuilder(List<ISaleItem> _list)
        {
            rp.ReceiptBuilder(_list);
            rp.ReceiptView();
        }

        IInvoiceProcessor ip = Factory.CreateInvoiceProcessor();
        
        public void InvoiceDetailsBuilder(List<ISaleItem> _list, string name, string postCode, string city, string street, string streetNumber, string taxNumber)
        {
            IVendor v = Factory.CreateVendor(); // dane z modelu
            IBuyer b = Factory.CreateBuyer();
            IInvoice i = Factory.CreateInvoice(); // dane z modelu
            // dodac model obsługujący płatności!

            b.BuyerName = name;
            b.BuyerPostCode = postCode;
            b.BuyerCity = city;
            b.BuyerStreet = street;
            b.BuyerStreetNumber = streetNumber;
            b.BuyerTaxNumber = taxNumber;

            //ip.InvoiceList(_list ,b, v, i);
            ip.InvoiceListNew(_list, b, v, i);

            // dodać funkcję przesyłającą dane klienta ze sklepu;
        }
    }
}
