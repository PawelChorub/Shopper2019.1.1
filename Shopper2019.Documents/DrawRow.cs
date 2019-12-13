using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents
{
    public class DrawRow
    {
        public void DrawRowCreate(System.Drawing.Printing.PrintPageEventArgs e, int y, string c1, string c2, string c3, string c4, string c5, string c6, string c7, string c8, string c9)
        {
            Pen blackPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

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

    }
}
