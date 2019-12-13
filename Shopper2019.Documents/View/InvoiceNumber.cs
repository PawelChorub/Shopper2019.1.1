using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class InvoiceNumber
    {
        public void CreateInvoiceNumberCreate(System.Drawing.Printing.PrintPageEventArgs e, string text)
        {
            Pen blackPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            String textInput = "Faktura VAT nr: " + text + "/" + DateTime.Today.Year;
            StringFormat textFormat = new StringFormat();
            textFormat.Alignment = StringAlignment.Center;

            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 20, FontStyle.Bold);

            RectangleF r = new RectangleF(15, 130, 760, 30);
            e.Graphics.DrawRectangle(blackPen, 15, 115, 760, 60);
            e.Graphics.DrawString(textInput, drawFont, drawBrush, r, textFormat);
        }

    }
}
