using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class SignatureSpace
    {

        public void CreateSignatureSpace(System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            Font drawFont = new Font("Arial", 6, FontStyle.Regular);

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

    }
}
