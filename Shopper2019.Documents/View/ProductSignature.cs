using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class ProductSignature
    {
        public void CreateProductSignature(PrintPageEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            Font drawFont = new Font("Arial", 6, FontStyle.Regular);

            e.Graphics.DrawLine(blackPen, new Point(15, 1085), new Point(775, 1085));
            e.Graphics.DrawString("Wydrukowano z programu Shopper 2019. \u00a9 Wszelkie prawa zastrzeżone przez papaceha.",
                new Font("Arial", 6, FontStyle.Regular),
                drawBrush,
                new RectangleF(15, 1085, 760, 20));
        }

    }
}
