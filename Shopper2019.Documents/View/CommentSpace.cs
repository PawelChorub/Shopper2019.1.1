using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class CommentSpace
    {
        public void CreateCommentSpace(System.Drawing.Printing.PrintPageEventArgs e, string text)
        {
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            String commentText = "Uwagi : " + text;
            Font drawFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);

            RectangleF r1 = new RectangleF(15, 865, 760, 40);
            //e.Graphics.DrawRectangle(blackPen, 15, 865, 760, 40);
            e.Graphics.DrawString(commentText, drawFont, drawBrush, r1);
        }

    }
}
