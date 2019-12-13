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
            string[] _cell = new string[9];
            DrawRow drawRow = new DrawRow();
            void RowCreate(int y, string[] cell)
            {
                drawRow.DrawRowCreate(e, y, cell);
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

                    _cell[0] = i.ToString();
                    _cell[1] = data.Code + " / " + data.Name;
                    _cell[2] = data.SaleQuantity.ToString();
                    _cell[3] = data.UnitOfMeasurements;
                    _cell[4] = data.Net_Price.ToString();
                    _cell[5] = (data.Net_Price * data.SaleQuantity).ToString("F");
                    _cell[6] = data.VatValue.ToString();
                    _cell[7] = ((data.Net_Price * data.VatValue) / 100).ToString("F");
                    _cell[8] = data.TotalGross_Price.ToString("F");

                    RowCreate(yPoint, _cell);


                    //sumowanie FV
                    totalAmount += data.TotalGross_Price;

                    InvoiceSummaryMethod(data.VatValue, (((data.Net_Price * data.VatValue) / 100) * data.SaleQuantity),
                        data.Net_Price * data.SaleQuantity,
                        data.Gross_Price * data.SaleQuantity);
                    //--koniec linii
                    endAnchor.X = x;
                    endAnchor.Y = yPoint + 20;
                    yPoint = startAnchor.Y + (20 * (rowMultiplier));
                }
            }

            InvoiceSummaryProcessor invoiceSummaryProcessor = new InvoiceSummaryProcessor();
            void InvoiceSummaryMethod(int? tax, decimal taxValue, decimal netPrice, decimal grossPrice)
            {
                invoiceSummaryProcessor.CreateInvoiceSummaryProcessor(tax, taxValue, netPrice, grossPrice, ref _taxFreeSummary, ref _tax5summary, ref _tax8summary, ref _tax23summary, ref _netPrice5summary, ref _netPrice8summary, ref _netPrice23summary, ref _netPriceFreeSummary, ref _grossPrice5summary, ref _grossPrice8summary, ref _grossPrice23summary, ref _grossPriceFreeSummary);
            }

            void InvoiceSummary(int y, string _totalAmount)
            {
                y = CreateInvoiceSummary(e, y, _totalAmount, _taxFreeSummary, _tax5summary, _tax8summary, _tax23summary, _netPrice5summary, _netPrice8summary, _netPrice23summary, _netPriceFreeSummary, _grossPrice5summary, _grossPrice8summary, _grossPrice23summary, _grossPriceFreeSummary);
            }

            //---------------------------------------------------------------------
            //Rysowanie obszaru roboczego
            MainWorkFrame mainWorkFrame = new MainWorkFrame();
            e.Graphics.DrawRectangle(new Pen(Color.Black), mainWorkFrame.CreateMainWorkFrame());
            //-Logo, Daty
            InvoiceHeader invoiceHeader = new InvoiceHeader();
            invoiceHeader.CreateHeaderCreate(e, "Częstochowa, " + DateTime.Now.ToShortDateString());

            //-numeracja
            InvoiceNumber invoiceNumber = new InvoiceNumber();
            invoiceNumber.CreateInvoiceNumberCreate(e, "125364");

            //-sprzed/kupuj
            VendorAndBuyerHeader vendorAndBuyerHeader = new VendorAndBuyerHeader();
            vendorAndBuyerHeader.CreateVendorAndBuyerCreate(e);

            //-dane sprzed - kupuj
            VendorAndBuyerDetail vendorAndBuyerDetail = new VendorAndBuyerDetail();
            vendorAndBuyerDetail.CreateVendorAndBuyerDetailsCreate(e, _vendor, _buyer);

            //-tabela
            InvoiceDetailHeader invoiceDetailHeader = new InvoiceDetailHeader();
            invoiceDetailHeader.CreateInvoiceDetailsHeaderCreate(e);

            //----Obsługa tabeli rozszerzalnej
            //=====================================
            RowCreateProcessor();
            //----Obsługa tabeli rozszerzalnej koniec

            //-podsumowanie
            InvoiceSummary(endAnchor.Y, totalAmount.ToString("F"));
            //=====================================

            //-kwota do zapl
            TotalAmountProcessor totalAmountProcessor = new TotalAmountProcessor();
            totalAmountProcessor.CreateTotalAmount(e, totalAmount.ToString("F"));

            //-płatności
            PaymentDetails paymentDetails = new PaymentDetails();
            paymentDetails.CreatePaymentDetails(e);

            //-bank
            BankDetails bankDetails = new BankDetails();
            bankDetails.CreateBankDetails(e);

            //-uwagi
            CommentSpace commentSpace = new CommentSpace();
            commentSpace.CreateCommentSpace(e, "Towar dostarczony transportem nabywcy.");

            //-podpisy
            SignatureSpace signatureSpace = new SignatureSpace();
            signatureSpace.CreateSignatureSpace(e);

            //-linia kończąca
            ProductSignature productSignature = new ProductSignature();
            productSignature.CreateProductSignature(e);
        }

        private int CreateInvoiceSummary(System.Drawing.Printing.PrintPageEventArgs e, int y, string _totalAmount, decimal _taxFreeSummary, decimal _tax5summary, decimal _tax8summary, decimal _tax23summary, decimal _netPrice5summary, decimal _netPrice8summary, decimal _netPrice23summary, decimal _netPriceFreeSummary, decimal _grossPrice5summary, decimal _grossPrice8summary, decimal _grossPrice23summary, decimal _grossPriceFreeSummary)
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

            return y;
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