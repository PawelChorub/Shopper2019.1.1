using Autofac;
using Shopper2019.Documents.Controllers;
using Shopper2019.Documents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents
{
    public static class Factory
    {
        public static IContainer Config()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ReceiptProcessor>().As<IReceiptProcessor>();
            builder.RegisterType<Receipt>().As<IReceipt>();
            builder.RegisterType<Invoice>().As<IInvoice>();
            builder.RegisterType<InvoiceProcessor>().As<IInvoiceProcessor>();
            builder.RegisterType<Buyer>().As<IBuyer>();
            builder.RegisterType<Vendor>().As<IVendor>();


            return builder.Build();
        }
    }
}
