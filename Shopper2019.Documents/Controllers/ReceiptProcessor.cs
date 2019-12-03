using Shopper2019.Documents.Models;
using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents
{
    public class ReceiptProcessor : IReceiptProcessor, IReceipt
    {
        IReceipt receipt = Factory.CreateReceipt(); 

        public string ReceiptHeader { get; set; } = "               Nazwa Firmy\n" +
                                                    "            42-200 Częstochowa\n" +
                                                    "              ul. Dziurawa 00\n" +
                                                    "            NIP: 949-494-94-49\n" +
                                                    "             tel: 721-123-456\n\n";
                                                   //----------------------------------------
        public string DateAndTime { get; set; } = string.Format(DateTime.Now.ToShortDateString().PadRight(30) + "{0,10}", DateTime.Now.ToShortTimeString())+"\n";
        public string ReceiptDetails { get; set; }
        public string ReceiptFooter { get; set; } = "Kasjer: KASJER-1".PadLeft(40) + "\n\n" +
                                                    "Zapraszamy ponownie\n" +
                                                    "www.moj-e-sklep.pl";
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
            ReceiptDocument r = new ReceiptDocument();
            r.SetReceiptDetails(receipt.ReceiptHeader + receipt.DateAndTime + receipt.ReceiptDetails + receipt.ReceiptFooter);
            r.Show();
        }
    }
}
