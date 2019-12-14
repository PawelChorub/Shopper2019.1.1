using Autofac;
using Shopper2019.Documents.Models;
using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;

namespace Shopper2019.Documents
{
    public class ReceiptProcessor : IReceiptProcessor
    {
        IContainer container;

        IReceipt receipt;

        public ReceiptProcessor()
        {
            container = Factory.Config();

            receipt = container.Resolve<IReceipt>();
        }
        public string ReceiptHeader { get; } = SetReceiptHeader();
        public string DateAndTime { get; } = SetReceiptDateAndTime();
        public string ReceiptDetails { get; set; }
        public string ReceiptFooter { get; } = SetReceiptFooter();
        public string CashierName { get; } = SetCashierName();
        public string VendorWebUrl { get; set; } = SetVendorWebUrl();

        private static string SetVendorWebUrl()
        {
            return "www.moj-e-sklep.pl";
        }

        private static string SetCashierName()
        {
            return "Kasjer-1";
        }

        private static string SetReceiptFooter()
        {
            return string.Format("Kasjer: {0}".PadLeft(35) + "\n\n" +
                    "Zapraszamy ponownie\n" +
                    "{1}", SetCashierName(), SetVendorWebUrl());
        }

        private static string SetReceiptDateAndTime()
        {
            return string.Format(DateTime.Now.ToShortDateString().PadRight(30) +
                "{0,10}", DateTime.Now.ToShortTimeString()) +
                "\n";
        }

        private static string SetReceiptHeader()
        {
           return   "               Nazwa Firmy\n" +
                    "            42-200 Częstochowa\n" +
                    "              ul. Dziurawa 00\n" +
                    "            NIP: 949-494-94-49\n" +
                    "             tel: 721-123-456\n\n";
                    //----------------------------------------
        }
        public void ReceiptBuilder(List<ISaleItem> list)
        {
            decimal total = 0;
            string receiptDetails = "";
            receiptDetails += "----------------------------------------\n\n";

            foreach (var item in list)
            {
                if (item.Name.Length >= 20)
                {
                    receiptDetails += item.Name.PadRight(35).Remove(25) + "\n";
                    receiptDetails += (item.SaleQuantity.ToString("F") + " " + item.UnitOfMeasurements + " * " + item.Gross_Price.ToString("F") + " " + item.TotalGross_Price.ToString("F")).PadLeft(40) + "\n";
                    total += item.TotalGross_Price;
                }
                else
                {
                    receiptDetails += item.Name.PadRight(35) + "\n";
                    receiptDetails += (item.SaleQuantity.ToString("F") + " " + item.UnitOfMeasurements + " * " + item.Gross_Price.ToString("F") + " " + item.TotalGross_Price.ToString("F")).PadLeft(40) + "\n";
                    total += item.TotalGross_Price;
                }
            }
            receiptDetails += "----------------------------------------\n\n";
            receiptDetails += string.Format("SUMA : ".PadRight(30) + "{0,10}", total.ToString("F")) + "\n\n";
            receipt.ReceiptHeader = ReceiptHeader;
            receipt.DateAndTime = DateAndTime;
            receipt.ReceiptDetails = receiptDetails;
            receipt.ReceiptFooter = ReceiptFooter;
        }

        public void ReceiptView()
        {
            ReceiptDocument receiptDocument = new ReceiptDocument();
            receiptDocument.SetReceiptDetails(receipt.ReceiptHeader + receipt.DateAndTime + receipt.ReceiptDetails + receipt.ReceiptFooter);
            receiptDocument.Show();
        }
    }
}
