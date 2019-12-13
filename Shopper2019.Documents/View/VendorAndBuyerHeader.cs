using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class VendorAndBuyerHeader
    {
        private SolidBrush drawBrushGray = new SolidBrush(Color.LightGray);
        private SolidBrush drawBrush = new SolidBrush(Color.Black);

        public void CreateVendorAndBuyerCreate(System.Drawing.Printing.PrintPageEventArgs e)
        {
            String vendorTitle = "Sprzedawca";
            String buyerTitle = "Nabywca";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 14, FontStyle.Bold);

            RectangleF r1 = new RectangleF(15, 175, 380, 40);
            e.Graphics.FillRectangle(drawBrushGray, 15, 175, 380, 40);
            e.Graphics.DrawString(vendorTitle, drawFont, drawBrush, r1);

            RectangleF r2 = new RectangleF(395, 175, 380, 40);
            e.Graphics.FillRectangle(drawBrushGray, 395, 175, 380, 40);
            e.Graphics.DrawString(buyerTitle, drawFont, drawBrush, r2);
        }

    }
}
