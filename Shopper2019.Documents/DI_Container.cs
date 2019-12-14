using Autofac;
using Shopper2019.Documents.Controllers;
using Shopper2019.Documents.Models;
using Shopper2019.Documents.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents
{
    public static class DI_Container
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

            builder.RegisterType<DrawRow>().AsSelf();
            builder.RegisterType<InvoiceSummaryProcessor>().AsSelf();
            builder.RegisterType<BankDetails>().AsSelf();
            builder.RegisterType<CommentSpace>().AsSelf();
            builder.RegisterType<InvoiceDetailHeader>().AsSelf();
            builder.RegisterType<InvoiceHeader>().AsSelf();
            builder.RegisterType<InvoiceNumber>().AsSelf();
            builder.RegisterType<MainWorkFrame>().AsSelf();
            builder.RegisterType<PaymentDetails>().AsSelf();
            builder.RegisterType<ProductSignature>().AsSelf();
            builder.RegisterType<SignatureSpace>().AsSelf();
            builder.RegisterType<TotalAmountProcessor>().AsSelf();
            builder.RegisterType<VendorAndBuyerDetail>().AsSelf();
            builder.RegisterType<VendorAndBuyerHeader>().AsSelf();

            builder.RegisterType<BusinessLogic_Documents>().As<IBusinessLogic_Documents>();

            builder.RegisterType<TaxSummary>().AsSelf();
            builder.RegisterType<DrawRow>().AsSelf();




            return builder.Build();
        }
    }
}
