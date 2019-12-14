using System.Drawing;

namespace Shopper2019.Documents
{
    public class DrawRow
    {
        public void DrawRowCreate(System.Drawing.Printing.PrintPageEventArgs e, int y, string[] cell)
        {
            Pen blackPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            StringFormat textFormat = new StringFormat();
            textFormat.Alignment = StringAlignment.Near;

            StringFormat digitFormat = new StringFormat();
            digitFormat.Alignment = StringAlignment.Far;

            Font drawFont = new Font("Arial", 10, FontStyle.Regular);
            // kolejna
            RectangleF r1 = new RectangleF(15, y, 24, 20);
            e.Graphics.DrawRectangle(blackPen, 15, y, 24, 20);
            e.Graphics.DrawString(cell[0], drawFont, drawBrush, r1, digitFormat);

            //nazwa
            RectangleF r2 = new RectangleF(39, y, 288, 20);
            e.Graphics.DrawRectangle(blackPen, 39, y, 288, 20);
            e.Graphics.DrawString(cell[1], drawFont, drawBrush, r2, textFormat);
            // ilosc
            RectangleF r3 = new RectangleF(327, y, 60, 20);
            e.Graphics.DrawRectangle(blackPen, 327, y, 60, 20);
            e.Graphics.DrawString(cell[2], drawFont, drawBrush, r3, digitFormat);
            // jm
            RectangleF r4 = new RectangleF(387, y, 40, 20);
            e.Graphics.DrawRectangle(blackPen, 387, y, 40, 20);
            e.Graphics.DrawString(cell[3], drawFont, drawBrush, r4, textFormat);
            // cNet
            RectangleF r5 = new RectangleF(427, y, 72, 20);
            e.Graphics.DrawRectangle(blackPen, 427, y, 72, 20);
            e.Graphics.DrawString(cell[4], drawFont, drawBrush, r5, digitFormat);
            // wNet
            RectangleF r6 = new RectangleF(499, y, 72, 20);
            e.Graphics.DrawRectangle(blackPen, 499, y, 72, 20);
            e.Graphics.DrawString(cell[5], drawFont, drawBrush, r6, digitFormat);
            // %
            RectangleF r7 = new RectangleF(571, y, 24, 20);
            e.Graphics.DrawRectangle(blackPen, 571, y, 24, 20);
            e.Graphics.DrawString(cell[6], drawFont, drawBrush, r7, digitFormat);
            // taxVal
            RectangleF r8 = new RectangleF(595, y, 72, 20);
            e.Graphics.DrawRectangle(blackPen, 595, y, 72, 20);
            e.Graphics.DrawString(cell[7], drawFont, drawBrush, r8, digitFormat);
            //GrossPr
            RectangleF r9 = new RectangleF(667, y, 108, 20);
            e.Graphics.DrawRectangle(blackPen, 667, y, 108, 20);
            e.Graphics.DrawString(cell[8], drawFont, drawBrush, r9, digitFormat);
        }

    }
}
