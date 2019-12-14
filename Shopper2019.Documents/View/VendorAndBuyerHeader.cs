using System;
using System.Drawing;
using System.Drawing.Printing;

namespace Shopper2019.Documents.View
{
    public class VendorAndBuyerHeader
    {
        private SolidBrush drawBrushGray = new SolidBrush(Color.LightGray);
        private SolidBrush drawBrush = new SolidBrush(Color.Black);

        public void CreateVendorAndBuyerCreate(PrintPageEventArgs e)
        {
            String vendorTitle = "Sprzedawca";
            String buyerTitle = "Nabywca";
            Font drawFont = new Font("Arial", 14, FontStyle.Bold);

            RectangleF r1 = new RectangleF(15, 175, 380, 40);
            e.Graphics.FillRectangle(drawBrushGray, 15, 175, 380, 40);
            e.Graphics.DrawString(vendorTitle, drawFont, drawBrush, r1);

            RectangleF r2 = new RectangleF(395, 175, 380, 40);
            e.Graphics.FillRectangle(drawBrushGray, 395, 175, 380, 40);
            e.Graphics.DrawString(buyerTitle, drawFont, drawBrush, r2);
        }

    }
}
