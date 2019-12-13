using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class InvoiceHeader
    {
        public void CreateHeaderCreate(System.Drawing.Printing.PrintPageEventArgs e, string text)
        {
            Pen blackPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            Image logoImg = Image.FromFile("c:\\users\\paweł.000\\desktop\\logo.jpg");
            //String logoText = "LOGO";
            String textInput = text;
            StringFormat logoFormat = new StringFormat();
            logoFormat.Alignment = StringAlignment.Center;
            StringFormat textFormat = new StringFormat();
            textFormat.Alignment = StringAlignment.Far;

            Font drawFont = new Font("Arial", 10, FontStyle.Regular);

            //RectangleF logoRectangle = new RectangleF(15, 15, 380, 20);
            e.Graphics.DrawImage(logoImg, 15, 15);

            //e.Graphics.DrawRectangle(blackPen, 15, 15, 380, 100);
            //e.Graphics.DrawString(logoText, drawFont, drawBrush, logoRectangle, logoFormat);

            RectangleF dateAndTimeRectangle = new RectangleF(395, 15, 380, 100);
            e.Graphics.DrawRectangle(blackPen, 395, 15, 380, 100);
            e.Graphics.DrawString(textInput, drawFont, drawBrush, dateAndTimeRectangle, textFormat);
        }

    }
}
