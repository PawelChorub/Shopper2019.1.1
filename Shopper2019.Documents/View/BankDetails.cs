using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class BankDetails
    {
        public void CreateBankDetails(PrintPageEventArgs e)
        {
            String bankName = "BZ WBK S.A.";
            String bankAccount = "12 1234 1456 0000 3250 0258 9639";
            Font drawFont = new Font("Arial", 10, FontStyle.Regular);
            Font drawFontBold = new Font("Arial", 10, FontStyle.Bold);
            Pen blackPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

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

    }
}
