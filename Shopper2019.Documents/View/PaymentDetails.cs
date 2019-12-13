using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class PaymentDetails
    {
        public void CreatePaymentDetails(System.Drawing.Printing.PrintPageEventArgs e)
        {
            String paymentMethod = "przelew";
            String paymentDeadline = "19-06-2019";
            Font drawFont = new Font("Arial", 10, FontStyle.Regular);
            Font drawFontBold = new Font("Arial", 10, FontStyle.Bold);
            Pen blackPen = new Pen(Color.Black);

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

    }
}
