using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class TotalAmountProcessor
    {
        DigitRecognizer.DigitRecognizer digitRecognizer = new DigitRecognizer.DigitRecognizer();

        public void CreateTotalAmount(PrintPageEventArgs e, string amount)
        {
            SolidBrush drawBrushLightGray = new SolidBrush(Color.LightGray);
            Pen blackPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            //String amount = "1234,25";
            String amountInWords = digitRecognizer.Run(amount);
            Font drawFont = new Font("Arial", 10, FontStyle.Regular);
            Font drawFontBold = new Font("Arial", 10, FontStyle.Bold);
            Font drawFontBoldBig = new Font("Arial", 18, FontStyle.Bold);
            Font drawFontSmall = new Font("Arial", 8, FontStyle.Regular);

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

    }
}
