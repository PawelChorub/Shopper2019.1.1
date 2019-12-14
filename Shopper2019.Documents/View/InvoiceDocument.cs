using Autofac;
using Shopper2019.Documents.Models;
using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Shopper2019.Documents.View
{
    public partial class InvoiceDocument : Form
    {
        IContainer container;

        MainWorkFrame mainWorkFrame;
        InvoiceHeader invoiceHeader;
        InvoiceNumber invoiceNumber;
        VendorAndBuyerHeader vendorAndBuyerHeader;
        VendorAndBuyerDetail vendorAndBuyerDetail;
        InvoiceDetailHeader invoiceDetailHeader;
        TotalAmountProcessor totalAmountProcessor;
        PaymentDetails paymentDetails;
        BankDetails bankDetails;
        CommentSpace commentSpace;
        SignatureSpace signatureSpace;
        ProductSignature productSignature;
        InvoiceSummaryProcessor invoiceSummaryProcessor;

        TaxSummary taxSummary;
        DrawRow drawRow;


        public InvoiceDocument()
        {
            container = DI_Container.Config();

            mainWorkFrame = container.Resolve<MainWorkFrame>();
            invoiceHeader = container.Resolve<InvoiceHeader>();
            invoiceNumber = container.Resolve<InvoiceNumber>();
            vendorAndBuyerHeader = container.Resolve<VendorAndBuyerHeader>();
            vendorAndBuyerDetail = container.Resolve<VendorAndBuyerDetail>();
            invoiceDetailHeader = container.Resolve<InvoiceDetailHeader>();
            totalAmountProcessor = container.Resolve<TotalAmountProcessor>();
            paymentDetails = container.Resolve<PaymentDetails>();
            bankDetails = container.Resolve<BankDetails>();
            commentSpace = container.Resolve<CommentSpace>();
            signatureSpace = container.Resolve<SignatureSpace>();
            productSignature = container.Resolve<ProductSignature>();
            invoiceSummaryProcessor = container.Resolve<InvoiceSummaryProcessor>();
            taxSummary = container.Resolve<TaxSummary>();
            drawRow = container.Resolve<DrawRow>();

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

        private List<ISaleItem> InvoiceItems = new List<ISaleItem>();

        public void InvoiceListData(List<ISaleItem> _list)
        {
            foreach (var item in _list)
            {
                InvoiceItems.Add(item);
            }
        }

        private IVendor _vendor;
        public void InvoiceVendor(IVendor vendor)
        {
            _vendor = vendor;
        }

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

        private void InvoicePrintingProcessor(PrintPageEventArgs e)
        {
            decimal totalAmount = 0;

            string[] _cell = new string[9];

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

                    InvoiceSummaryMethod(data.VatValue, 
                        (((data.Net_Price * data.VatValue) / 100) * data.SaleQuantity),
                        data.Net_Price * data.SaleQuantity,
                        data.Gross_Price * data.SaleQuantity);
                    //--koniec linii
                    endAnchor.X = x;
                    endAnchor.Y = yPoint + 20;
                    yPoint = startAnchor.Y + (20 * (rowMultiplier));
                }
            }

            void InvoiceSummaryMethod(int? tax, decimal taxValue, decimal netPrice, decimal grossPrice)
            {
                invoiceSummaryProcessor.CreateInvoiceSummaryProcessor(tax, taxValue, netPrice, grossPrice, ref taxSummary);
            }

            void InvoiceSummary(int y, string _totalAmount)
            {
                y = CreateInvoiceSummary(e, y, _totalAmount, taxSummary);
            }

            //---------------------------------------------------------------------
            //Rysowanie obszaru roboczego
            e.Graphics.DrawRectangle(new Pen(Color.Black), mainWorkFrame.CreateMainWorkFrame());
            //-Logo, Daty
            invoiceHeader.CreateHeaderCreate(e, "Częstochowa, " + DateTime.Now.ToShortDateString());

            //-numeracja
            invoiceNumber.CreateInvoiceNumberCreate(e, "125364");

            //-sprzed/kupuj
            vendorAndBuyerHeader.CreateVendorAndBuyerCreate(e);

            //-dane sprzed - kupuj
            vendorAndBuyerDetail.CreateVendorAndBuyerDetailsCreate(e, _vendor, _buyer);

            //-tabela
            invoiceDetailHeader.CreateInvoiceDetailsHeaderCreate(e);

            //===============================================================
            //----Obsługa tabeli rozszerzalnej
            RowCreateProcessor();
            //----Obsługa tabeli rozszerzalnej koniec

            //-podsumowanie
            InvoiceSummary(endAnchor.Y, totalAmount.ToString("F"));
            //===============================================================

            //-kwota do zapl
            totalAmountProcessor.CreateTotalAmount(e, totalAmount.ToString("F"));

            //-płatności
            paymentDetails.CreatePaymentDetails(e);

            //-bank
            bankDetails.CreateBankDetails(e);

            //-uwagi
            commentSpace.CreateCommentSpace(e, "Towar dostarczony transportem nabywcy.");

            //-podpisy
            signatureSpace.CreateSignatureSpace(e);

            //-linia kończąca
            productSignature.CreateProductSignature(e);
        }

        private int CreateInvoiceSummary(PrintPageEventArgs e, int y, string _totalAmount, TaxSummary taxSummary)
        {
            //String inputText = text;
            Font drawFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
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
            string[] netLabel = { taxSummary._netPrice5summary.ToString("F"), taxSummary._netPrice8summary.ToString("F"), taxSummary._netPrice23summary.ToString("F"), taxSummary._netPriceFreeSummary.ToString("F") };
            string[] grossLabel = { taxSummary._grossPrice5summary.ToString("F"), taxSummary._grossPrice8summary.ToString("F"), taxSummary._grossPrice23summary.ToString("F"), taxSummary._grossPriceFreeSummary.ToString("F") };
            string[] taxLabel = { taxSummary._tax5summary.ToString("F"), taxSummary._tax8summary.ToString("F"), taxSummary._tax23summary.ToString("F"), taxSummary._taxFreeSummary.ToString("F") };
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

        private void PrintDocumentInvoice_PrintPage(object sender, PrintPageEventArgs e)
        {
            InvoicePrintingProcessor(e);
        }

        private void PrintPreviewDialogInvoice_Load(object sender, EventArgs e) { }

        private void Button1_Click(object sender, EventArgs e)
        {
            printPreviewDialogInvoice.Document = printDocumentInvoice;
            printDialogInvoice.ShowDialog();

            printDialogInvoice.Document = printDocumentInvoice;
            printPreviewDialogInvoice.Show();
            this.Close();
        }
    }
}