using Autofac;
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
        IContainer container;

        IReceiptProcessor receiptProcessor;
        IInvoiceProcessor invoiceProcessor;
        IVendor vendor;
        IBuyer buyer;
        IInvoice invoice;

        public BusinessLogic_Documents()
        {
            container = Factory.Config();

            receiptProcessor = container.Resolve<IReceiptProcessor>();
            invoiceProcessor = container.Resolve<IInvoiceProcessor>();
            vendor = container.Resolve<IVendor>();
            buyer = container.Resolve<IBuyer>();
            invoice = container.Resolve<IInvoice>();
        }


        public void ReceiptDetailsBuilder(List<ISaleItem> _list)
        {
            receiptProcessor.ReceiptBuilder(_list);
            receiptProcessor.ReceiptView();
        }

        
        public void InvoiceDetailsBuilder(List<ISaleItem> _list, string name, string postCode, string city, string street, string streetNumber, string taxNumber)
        {
            buyer.BuyerName = name;
            buyer.BuyerPostCode = postCode;
            buyer.BuyerCity = city;
            buyer.BuyerStreet = street;
            buyer.BuyerStreetNumber = streetNumber;
            buyer.BuyerTaxNumber = taxNumber;

            invoiceProcessor.InvoiceListNew(_list, buyer, vendor, invoice);
        }
    }
}
