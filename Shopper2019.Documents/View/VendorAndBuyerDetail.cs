using Shopper2019.Documents.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class VendorAndBuyerDetail
    {
        public void CreateVendorAndBuyerDetailsCreate(PrintPageEventArgs e, IVendor v, IBuyer b)
        {
            Pen blackPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            String vendorDetails = v.Name + "\n" + v.PostCode + " " + v.City + "\n" + v.Street + " " + v.StreetNumber + "\n" + v.TaxNumber;
            String buyerDetails = b.BuyerName + "\n" + b.BuyerPostCode + " " + b.BuyerCity + "\n" + b.BuyerStreet + " " + b.BuyerStreetNumber + "\n" + b.BuyerTaxNumber;
            Font drawFont = new Font("Arial", 12, FontStyle.Regular);

            RectangleF r1 = new RectangleF(15, 215, 380, 80);
            e.Graphics.DrawRectangle(blackPen, 15, 215, 380, 80);
            e.Graphics.DrawString(vendorDetails, drawFont, drawBrush, r1);

            RectangleF r2 = new RectangleF(395, 215, 380, 80);
            e.Graphics.DrawRectangle(blackPen, 395, 215, 380, 80);
            e.Graphics.DrawString(buyerDetails, drawFont, drawBrush, r2);
        }

    }
}
