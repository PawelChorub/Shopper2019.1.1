using Shopper2019.Documents.Models;
using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shopper2019.Documents.View
{
    public partial class InvoiceDocument : Form
    {
        public InvoiceDocument()
        {
            InitializeComponent();
        }
        Shopper2019.DigitRecognizer.DigitRecognizer digitRecognizer = new Shopper2019.DigitRecognizer.DigitRecognizer();


        //poziomy punkt zakotwiczenia początku rozszerzalnej tabeli
        private Point startAnchor = new Point(15, 340);
        //poziomy punkt zakotwiczenia końca rozszerzalnej tabeli
        private Point endAnchor = new Point();

        private Pen blackPen = new Pen(Color.Black);
        private SolidBrush drawBrush = new SolidBrush(Color.Black);
        private SolidBrush drawBrushGray = new SolidBrush(Color.LightGray);
        private SolidBrush drawBrushLightGray = new SolidBrush(Color.LightGray);
        private SolidBrush drawBrushTransparent = new SolidBrush(Color.Transparent);

        //wejście listy rzeczy sprzedanych
        private List<ISaleItem> InvoiceItems = new List<ISaleItem>();

        public void InvoiceListData(List<ISaleItem> _list)
        {
            foreach (var item in _list)
            {
                InvoiceItems.Add(item);
            }
        }

        //sprzedawca
        private IVendor _vendor;
        public void InvoiceVendor(IVendor vendor)
        {
            _vendor = vendor;
        }

        //kupujący
        private IBuyer _buyer;
        public void InvoiceBuyer(IBuyer buyer)
        {
            _buyer = buyer;
        }

        //datowanie, numerowanie faktury
        //public void InvoiceOrder(IInvoice invoice)
        //{
        //    CityAndDateLbl.Text = "Częstochowa" + ", " + invoice.Date;
        //    InvoiceNumberLbl.Text = "Faktura VAT nr: " + (invoice.InvoiceNumber++).ToString() + "/" + invoice.InvoiceNumberYear;
        //}

        //grafika - obszar roboczy dla A4        
        private System.Drawing.Rectangle CreateMainWorkFrame()
        {
            System.Drawing.Rectangle mainFrame = new System.Drawing.Rectangle(15, 15, 760, 1085);
            return mainFrame;
        }

        private void InvoicePrintingProcessor(System.Drawing.Printing.PrintPageEventArgs e)
        {
            decimal totalAmount = 0;
            //podsumowanie w stawkach VAT
            decimal _taxFreeSummary = 0;
            decimal _tax5summary = 0;
            decimal _tax8summary = 0;
            decimal _tax23summary = 0;
            decimal _netPrice5summary = 0;
            decimal _netPrice8summary = 0;
            decimal _netPrice23summary = 0;
            decimal _netPriceFreeSummary = 0;
            decimal _grossPrice5summary = 0;
            decimal _grossPrice8summary = 0;
            decimal _grossPrice23summary = 0;
            decimal _grossPriceFreeSummary = 0;

            //----------------------------------------------------------------------
            void HeaderCreate(string text)
            {
                System.Drawing.Image logoImg = System.Drawing.Image.FromFile("c:\\users\\paweł.000\\desktop\\logo.jpg");
                //String logoText = "LOGO";
                String textInput = text;
                StringFormat logoFormat = new StringFormat();
                logoFormat.Alignment = StringAlignment.Center;
                StringFormat textFormat = new StringFormat();
                textFormat.Alignment = StringAlignment.Far;

                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);

                //RectangleF logoRectangle = new RectangleF(15, 15, 380, 20);
                e.Graphics.DrawImage(logoImg, 15, 15);

                //e.Graphics.DrawRectangle(blackPen, 15, 15, 380, 100);
                //e.Graphics.DrawString(logoText, drawFont, drawBrush, logoRectangle, logoFormat);

                RectangleF dateAndTimeRectangle = new RectangleF(395, 15, 380, 100);
                e.Graphics.DrawRectangle(blackPen, 395, 15, 380, 100);
                e.Graphics.DrawString(textInput, drawFont, drawBrush, dateAndTimeRectangle, textFormat);

            }
            void InvoiceNumberCreate(string text)
            {
                String textInput = "Faktura VAT nr: " + text + "/" + DateTime.Today.Year;
                StringFormat textFormat = new StringFormat();
                textFormat.Alignment = StringAlignment.Center;

                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 20, FontStyle.Bold);

                RectangleF r = new RectangleF(15, 130, 760, 30);
                e.Graphics.DrawRectangle(blackPen, 15, 115, 760, 60);
                e.Graphics.DrawString(textInput, drawFont, drawBrush, r, textFormat);
            }
            void VendorAndBuyerCreate()
            {
                String vendorTitle = "Sprzedawca";
                String buyerTitle = "Nabywca";
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 14, FontStyle.Bold);

                RectangleF r1 = new RectangleF(15, 175, 380, 40);
                e.Graphics.FillRectangle(drawBrushGray, 15, 175, 380, 40);
                e.Graphics.DrawString(vendorTitle, drawFont, drawBrush, r1);

                RectangleF r2 = new RectangleF(395, 175, 380, 40);
                e.Graphics.FillRectangle(drawBrushGray, 395, 175, 380, 40);
                e.Graphics.DrawString(buyerTitle, drawFont, drawBrush, r2);
            }
            void VendorAndBuyerDetailsCreate(IVendor v, IBuyer b)
            {
                String vendorDetails = v.Name + "\n" + v.PostCode + " " + v.City + "\n" + v.Street + " " + v.StreetNumber + "\n" + v.TaxNumber;
                String buyerDetails = b.BuyerName + "\n" + b.BuyerPostCode + " " + b.BuyerCity + "\n" + b.BuyerStreet + " " + b.BuyerStreetNumber + "\n" + b.BuyerTaxNumber;
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 12, FontStyle.Regular);

                RectangleF r1 = new RectangleF(15, 215, 380, 80);
                e.Graphics.DrawRectangle(blackPen, 15, 215, 380, 80);
                e.Graphics.DrawString(vendorDetails, drawFont, drawBrush, r1);

                RectangleF r2 = new RectangleF(395, 215, 380, 80);
                e.Graphics.DrawRectangle(blackPen, 395, 215, 380, 80);
                e.Graphics.DrawString(buyerDetails, drawFont, drawBrush, r2);
            }
            void InvoiceDatailsHeaderCreate()
            {
                StringFormat textFormat = new StringFormat();
                textFormat.Alignment = StringAlignment.Center;

                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 9, FontStyle.Regular);

                //lp
                RectangleF r1 = new RectangleF(15, 295, 24, 45);
                e.Graphics.FillRectangle(drawBrushLightGray, r1);

                e.Graphics.DrawRectangle(blackPen, 15, 295, 24, 45);
                e.Graphics.DrawString("Lp", drawFont, drawBrush, r1, textFormat);

                //nazwa + kod
                RectangleF r2 = new RectangleF(39, 295, 288, 45);
                e.Graphics.FillRectangle(drawBrushLightGray, r2);

                e.Graphics.DrawRectangle(blackPen, 39, 295, 288, 45);
                e.Graphics.DrawString("Nazwa towaru lub usługi", drawFont, drawBrush, r2, textFormat);
                // ilosc
                RectangleF r3 = new RectangleF(327, 295, 60, 45);
                e.Graphics.FillRectangle(drawBrushLightGray, 327, 295, 60, 45);

                e.Graphics.DrawRectangle(blackPen, 327, 295, 60, 45);
                e.Graphics.DrawString("Ilość", drawFont, drawBrush, r3, textFormat);
                // jm
                RectangleF r4 = new RectangleF(387, 295, 40, 45);
                e.Graphics.FillRectangle(drawBrushLightGray, 387, 295, 40, 45);

                e.Graphics.DrawRectangle(blackPen, 387, 295, 40, 45);
                e.Graphics.DrawString("J.m.", drawFont, drawBrush, r4, textFormat);
                // cNet
                RectangleF r5 = new RectangleF(427, 295, 72, 45);
                e.Graphics.FillRectangle(drawBrushLightGray, 427, 295, 72, 45);

                e.Graphics.DrawRectangle(blackPen, 427, 295, 72, 45);
                e.Graphics.DrawString("Cena netto (PLN)", drawFont, drawBrush, r5, textFormat);
                // wNet
                RectangleF r6 = new RectangleF(499, 295, 72, 45);
                e.Graphics.FillRectangle(drawBrushLightGray, 499, 295, 72, 45);

                e.Graphics.DrawRectangle(blackPen, 499, 295, 72, 45);
                e.Graphics.DrawString("Wartość netto (PLN)", drawFont, drawBrush, r6, textFormat);
                // %
                RectangleF r7 = new RectangleF(571, 295, 24, 45);
                e.Graphics.FillRectangle(drawBrushLightGray, 571, 295, 24, 45);

                e.Graphics.DrawRectangle(blackPen, 571, 295, 24, 45);
                e.Graphics.DrawString("Vat %", drawFont, drawBrush, r7, textFormat);
                // taxVal
                RectangleF r8 = new RectangleF(595, 295, 72, 45);
                e.Graphics.FillRectangle(drawBrushLightGray, 595, 295, 72, 45);

                e.Graphics.DrawRectangle(blackPen, 595, 295, 72, 45);
                e.Graphics.DrawString("Kwota VAT (PLN)", drawFont, drawBrush, r8, textFormat);
                //GrossPr
                RectangleF r9 = new RectangleF(667, 295, 108, 45);
                e.Graphics.FillRectangle(drawBrushLightGray, 667, 295, 108, 45);

                e.Graphics.DrawRectangle(blackPen, 667, 295, 108, 45);
                e.Graphics.DrawString("Wartość brutto (PLN)", drawFont, drawBrush, r9, textFormat);
            }
            void RowCreate(int y, string c1, string c2, string c3, string c4, string c5, string c6, string c7, string c8, string c9)
            {
                StringFormat textFormat = new StringFormat();
                textFormat.Alignment = StringAlignment.Near;

                StringFormat digitFormat = new StringFormat();
                digitFormat.Alignment = StringAlignment.Far;

                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
                // kolejna
                RectangleF r1 = new RectangleF(15, y, 24, 20);
                e.Graphics.DrawRectangle(blackPen, 15, y, 24, 20);
                e.Graphics.DrawString(c1, drawFont, drawBrush, r1, digitFormat);

                //nazwa
                RectangleF r2 = new RectangleF(39, y, 288, 20);
                e.Graphics.DrawRectangle(blackPen, 39, y, 288, 20);
                e.Graphics.DrawString(c2, drawFont, drawBrush, r2, textFormat);
                // ilosc
                RectangleF r3 = new RectangleF(327, y, 60, 20);
                e.Graphics.DrawRectangle(blackPen, 327, y, 60, 20);
                e.Graphics.DrawString(c3, drawFont, drawBrush, r3, digitFormat);
                // jm
                RectangleF r4 = new RectangleF(387, y, 40, 20);
                e.Graphics.DrawRectangle(blackPen, 387, y, 40, 20);
                e.Graphics.DrawString(c4, drawFont, drawBrush, r4, textFormat);
                // cNet
                RectangleF r5 = new RectangleF(427, y, 72, 20);
                e.Graphics.DrawRectangle(blackPen, 427, y, 72, 20);
                e.Graphics.DrawString(c5, drawFont, drawBrush, r5, digitFormat);
                // wNet
                RectangleF r6 = new RectangleF(499, y, 72, 20);
                e.Graphics.DrawRectangle(blackPen, 499, y, 72, 20);
                e.Graphics.DrawString(c6, drawFont, drawBrush, r6, digitFormat);
                // %
                RectangleF r7 = new RectangleF(571, y, 24, 20);
                e.Graphics.DrawRectangle(blackPen, 571, y, 24, 20);
                e.Graphics.DrawString(c7, drawFont, drawBrush, r7, digitFormat);
                // taxVal
                RectangleF r8 = new RectangleF(595, y, 72, 20);
                e.Graphics.DrawRectangle(blackPen, 595, y, 72, 20);
                e.Graphics.DrawString(c8, drawFont, drawBrush, r8, digitFormat);
                //GrossPr
                RectangleF r9 = new RectangleF(667, y, 108, 20);
                e.Graphics.DrawRectangle(blackPen, 667, y, 108, 20);
                e.Graphics.DrawString(c9, drawFont, drawBrush, r9, digitFormat);
            }
            void RowCreateProcessor()
            {
                // max input = 17 rows
                //int rowsNumber = 17;
                int yPoint = startAnchor.Y;
                int rowsNumber = InvoiceItems.Count;

                for (int i = 1; i <= rowsNumber; i++)
                {
                    int rowMultiplier = i;
                    var data = InvoiceItems.ElementAt(i - 1);
                    int x = startAnchor.X;

                    RowCreate(
                        yPoint,
                        i.ToString(),
                        data.Code + " / " + data.Name,
                        data.SaleQuantity.ToString(),
                        data.UnitOfMeasurements,
                        data.Net_Price.ToString(),
                        (data.Net_Price * data.SaleQuantity).ToString("F"),
                        data.VatValue.ToString(),
                        ((data.Net_Price * data.VatValue) / 100).ToString("F"),
                        data.TotalGross_Price.ToString("F"));

                    //sumowanie FV
                    totalAmount += data.TotalGross_Price;

                    InvoiceSummaryProcessor(data.VatValue, (((data.Net_Price * data.VatValue) / 100) * data.SaleQuantity),
                        data.Net_Price * data.SaleQuantity,
                        data.Gross_Price * data.SaleQuantity);
                    //--koniec linii
                    endAnchor.X = x;
                    endAnchor.Y = yPoint + 20;
                    yPoint = startAnchor.Y + (20 * (rowMultiplier));
                }
            }
            void InvoiceSummaryProcessor(int? tax, decimal taxValue, decimal netPrice, decimal grossPrice)
            {
                if (tax == 5)
                {
                    _tax5summary += taxValue;
                    _netPrice5summary += netPrice;
                    _grossPrice5summary += grossPrice;
                }
                else if (tax == 8)
                {
                    _tax8summary += taxValue;
                    _netPrice8summary += netPrice;
                    _grossPrice8summary += grossPrice;
                }
                else if (tax == 23)
                {
                    _tax23summary += taxValue;
                    _netPrice23summary += netPrice;
                    _grossPrice23summary += grossPrice;
                }
                else
                {
                    _taxFreeSummary += taxValue;
                    _netPriceFreeSummary += netPrice;
                    _grossPriceFreeSummary += grossPrice;
                }
            }
            void InvoiceSummary(int y, string _totalAmount)
            {
                //String inputText = text;
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
                StringFormat digitFormat = new StringFormat();
                digitFormat.Alignment = StringAlignment.Far;

                //--podsumowanie Brutto
                RectangleF summaryRectangle = new RectangleF(667, y, 108, 20);
                e.Graphics.DrawRectangle(blackPen, 667, y, 108, 20);
                e.Graphics.DrawString(_totalAmount, drawFont, drawBrush, summaryRectangle, digitFormat);

                //--podsumowanie Brutto
                RectangleF h1 = new RectangleF(499, y + 20, 276, 20);
                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), 499, y + 20, 276, 20);

                e.Graphics.DrawRectangle(blackPen, 499, y + 20, 276, 20);
                e.Graphics.DrawString("Podsumowanie według stawek VAT", drawFont, drawBrush, h1, digitFormat);
                y = y + 20;

                string[] vatPercentLabel = { "5", "8", "23", "zw" };
                string[] netLabel = { _netPrice5summary.ToString("F"), _netPrice8summary.ToString("F"), _netPrice23summary.ToString("F"), _netPriceFreeSummary.ToString("F") };
                string[] grossLabel = { _grossPrice5summary.ToString("F"), _grossPrice8summary.ToString("F"), _grossPrice23summary.ToString("F"), _grossPriceFreeSummary.ToString("F") };
                string[] taxLabel = { _tax5summary.ToString("F"), _tax8summary.ToString("F"), _tax23summary.ToString("F"), _taxFreeSummary.ToString("F") };
                for (int i = 0; i <= 3; i++)
                {
                    //--tabela summary
                    // wNet
                    RectangleF r6 = new RectangleF(499, y + 20, 72, 20);
                    e.Graphics.DrawRectangle(blackPen, 499, y + 20, 72, 20);
                    e.Graphics.DrawString(netLabel[i], drawFont, drawBrush, r6, digitFormat);
                    // %
                    RectangleF r7 = new RectangleF(571, y + 20, 24, 20);
                    e.Graphics.DrawRectangle(blackPen, 571, y + 20, 24, 20);
                    e.Graphics.DrawString(vatPercentLabel[i], drawFont, drawBrush, r7, digitFormat);
                    // taxVal
                    RectangleF r8 = new RectangleF(595, y + 20, 72, 20);
                    e.Graphics.DrawRectangle(blackPen, 595, y + 20, 72, 20);
                    e.Graphics.DrawString(taxLabel[i], drawFont, drawBrush, r8, digitFormat);
                    //GrossPr
                    RectangleF r9 = new RectangleF(667, y + 20, 108, 20);
                    e.Graphics.DrawRectangle(blackPen, 667, y + 20, 108, 20);
                    e.Graphics.DrawString(grossLabel[i], drawFont, drawBrush, r9, digitFormat);
                    y = y + 20;
                }
            }
            void TotalAmount(string amount)
            {
                //String amount = "1234,25";
                String amountInWords = digitRecognizer.Run(amount);
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
                System.Drawing.Font drawFontBold = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                System.Drawing.Font drawFontBoldBig = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                System.Drawing.Font drawFontSmall = new System.Drawing.Font("Arial", 8, FontStyle.Regular);

                RectangleF r1 = new RectangleF(15, 795, 120, 40);
                e.Graphics.FillRectangle(drawBrushLightGray, 15, 785, 120, 40);

                e.Graphics.DrawRectangle(blackPen, 15, 785, 120, 40);
                e.Graphics.DrawString("Do zapłaty: ", drawFontBold, drawBrush, r1);

                RectangleF r2 = new RectangleF(135, 795, 260, 40);
                e.Graphics.FillRectangle(drawBrushLightGray, 135, 785, 260, 40);

                e.Graphics.DrawRectangle(blackPen, 135, 785, 260, 40);
                e.Graphics.DrawString(amount + " zł", drawFontBoldBig, drawBrush, r2);

                RectangleF r3 = new RectangleF(395, 785, 120, 40);
                e.Graphics.DrawRectangle(blackPen, 395, 785, 120, 40);
                e.Graphics.DrawString("Kwota słownie:", drawFontBold, drawBrush, r3);

                RectangleF r4 = new RectangleF(515, 785, 260, 40);
                e.Graphics.DrawRectangle(blackPen, 515, 785, 260, 40);
                e.Graphics.DrawString(amountInWords, drawFontSmall, drawBrush, r4);

            }
            void PaymentDetails()
            {
                String paymentMethod = "przelew";
                String paymentDeadline = "19-06-2019";
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
                System.Drawing.Font drawFontBold = new System.Drawing.Font("Arial", 10, FontStyle.Bold);

                SolidBrush drawBrush = new SolidBrush(Color.Black);
                Pen blackPen2 = new Pen(Color.Black);

                RectangleF r1 = new RectangleF(15, 825, 120, 20);
                e.Graphics.DrawRectangle(blackPen, 15, 825, 120, 20);
                e.Graphics.DrawString("Sposób zapłaty: ", drawFontBold, drawBrush, r1);

                RectangleF r2 = new RectangleF(135, 825, 260, 20);
                e.Graphics.DrawRectangle(blackPen, 135, 825, 260, 20);
                e.Graphics.DrawString(paymentMethod, drawFont, drawBrush, r2);

                RectangleF r3 = new RectangleF(395, 825, 120, 20);
                e.Graphics.DrawRectangle(blackPen, 395, 825, 120, 20);
                e.Graphics.DrawString("Termin płatności", drawFontBold, drawBrush, r3);

                RectangleF r4 = new RectangleF(515, 825, 260, 20);
                e.Graphics.DrawRectangle(blackPen, 515, 825, 260, 20);
                e.Graphics.DrawString(paymentDeadline, drawFont, drawBrush, r4);
            }
            void BankDetails()
            {
                String bankName = "BZ WBK S.A.";
                String bankAccount = "12 1234 1456 0000 3250 0258 9639";
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
                System.Drawing.Font drawFontBold = new System.Drawing.Font("Arial", 10, FontStyle.Bold);

                RectangleF r1 = new RectangleF(15, 845, 120, 20);
                e.Graphics.DrawRectangle(blackPen, 15, 845, 120, 20);
                e.Graphics.DrawString("Bank:", drawFontBold, drawBrush, r1);

                RectangleF r2 = new RectangleF(135, 845, 260, 20);
                e.Graphics.DrawRectangle(blackPen, 135, 845, 260, 20);
                e.Graphics.DrawString(bankName, drawFont, drawBrush, r2);

                RectangleF r3 = new RectangleF(395, 845, 120, 20);
                e.Graphics.DrawRectangle(blackPen, 395, 845, 120, 20);
                e.Graphics.DrawString("Numer konta:", drawFontBold, drawBrush, r3);

                RectangleF r4 = new RectangleF(515, 845, 260, 20);
                e.Graphics.DrawRectangle(blackPen, 515, 845, 260, 20);
                e.Graphics.DrawString(bankAccount, drawFont, drawBrush, r4);
            }
            void CommentSpace(string text)
            {
                String commentText = "Uwagi : " + text;
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);

                RectangleF r1 = new RectangleF(15, 865, 760, 40);
                //e.Graphics.DrawRectangle(blackPen, 15, 865, 760, 40);
                e.Graphics.DrawString(commentText, drawFont, drawBrush, r1);
            }
            void SignatureSpace()
            {
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 6, FontStyle.Regular);

                RectangleF r1 = new RectangleF(15, 1005, 240, 20);
                //e.Graphics.DrawRectangle(blackPen, 15, 1005, 240, 20);
                e.Graphics.DrawLine(blackPen, 15, 1005, 245, 1005);
                e.Graphics.DrawString("podpis osoby upoważnionej do odbioru faktury VAT", drawFont, drawBrush, r1);

                RectangleF r2 = new RectangleF(265, 1005, 160, 20);
                //e.Graphics.DrawRectangle(blackPen, 265, 1005, 160, 20);
                e.Graphics.DrawLine(blackPen, 250, 1005, 350, 1005);
                e.Graphics.DrawString("data odbioru", drawFont, drawBrush, r2);

                RectangleF r3 = new RectangleF(480, 1005, 280, 20);
                //e.Graphics.DrawRectangle(blackPen, 520, 1005, 240, 20);
                e.Graphics.DrawLine(blackPen, 480, 1005, 775, 1005);
                e.Graphics.DrawString("podpis i pieczęć osoby upoważnionej do wystawienia faktury VAT", drawFont, drawBrush, r3);
            }
            void ProductSignature()
            {
                e.Graphics.DrawLine(blackPen, new Point(15, 1085), new Point(775, 1085));
                e.Graphics.DrawString("Wydrukowano z programu Shopper 2019. \u00a9 Wszelkie prawa zastrzeżone przez papaceha.",
                    new System.Drawing.Font("Arial", 6, FontStyle.Regular),
                    drawBrush,
                    new RectangleF(15, 1085, 760, 20));
            }
            //---------------------------------------------------------------------
            //Rysowanie obszaru roboczego
            e.Graphics.DrawRectangle(new Pen(Color.Black), CreateMainWorkFrame());
            //-Logo, Daty
            HeaderCreate("Częstochowa, " + DateTime.Now.ToShortDateString());
            //-numeracja
            InvoiceNumberCreate("125364");
            //-sprzed/kupuj
            VendorAndBuyerCreate();
            //-dane sprzed - kupuj
            VendorAndBuyerDetailsCreate(_vendor, _buyer);
            //-tabela
            InvoiceDatailsHeaderCreate();
            //----Obsługa tabeli rozszerzalnej
            RowCreateProcessor();
            //----Obsługa tabeli rozszerzalnej koniec
            //-podsumowanie
            InvoiceSummary(endAnchor.Y, totalAmount.ToString("F"));
            //-kwota do zapl
            TotalAmount(totalAmount.ToString("F"));
            //-płatności
            PaymentDetails();
            //-bank
            BankDetails();
            //-uwagi
            CommentSpace("Towar dostarczony transportem nabywcy.");
            //-podpisy
            SignatureSpace();
            //-linia kończąca
            ProductSignature();
        }

        private void PrintDocumentInvoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Rysowanie do wydruku
            InvoicePrintingProcessor(e);
        }

        private void PrintPreviewDialogInvoice_Load(object sender, EventArgs e)
        {
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            // wywolanie
            //// wybor druk/pdf
            printPreviewDialogInvoice.Document = printDocumentInvoice;
            printDialogInvoice.ShowDialog();

            // podglad
            printDialogInvoice.Document = printDocumentInvoice;
            printPreviewDialogInvoice.Show();
            this.Close();
        }
    }
}