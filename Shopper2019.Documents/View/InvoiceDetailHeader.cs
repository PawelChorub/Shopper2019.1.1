using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class InvoiceDetailHeader
    {
        private SolidBrush drawBrushLightGray = new SolidBrush(Color.LightGray);
        Pen blackPen = new Pen(Color.Black);
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        public void CreateInvoiceDetailsHeaderCreate(System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat textFormat = new StringFormat();
            textFormat.Alignment = StringAlignment.Center;

            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 9, FontStyle.Regular);

            //lp
            RectangleF r1 = new RectangleF(15, 295, 24, 45);
            e.Graphics.FillRectangle(drawBrushLightGray, r1);

            e.Graphics.DrawRectangle(blackPen, 15, 295, 24, 45);
            e.Graphics.DrawString("Lp", drawFont, drawBrush, r1, textFormat);

            //nazwa + kod
            RectangleF r2 = new RectangleF(39, 295, 288, 45);
            e.Graphics.FillRectangle(drawBrushLightGray, r2);

            e.Graphics.DrawRectangle(blackPen, 39, 295, 288, 45);
            e.Graphics.DrawString("Nazwa towaru lub usługi", drawFont, drawBrush, r2, textFormat);
            // ilosc
            RectangleF r3 = new RectangleF(327, 295, 60, 45);
            e.Graphics.FillRectangle(drawBrushLightGray, 327, 295, 60, 45);

            e.Graphics.DrawRectangle(blackPen, 327, 295, 60, 45);
            e.Graphics.DrawString("Ilość", drawFont, drawBrush, r3, textFormat);
            // jm
            RectangleF r4 = new RectangleF(387, 295, 40, 45);
            e.Graphics.FillRectangle(drawBrushLightGray, 387, 295, 40, 45);

            e.Graphics.DrawRectangle(blackPen, 387, 295, 40, 45);
            e.Graphics.DrawString("J.m.", drawFont, drawBrush, r4, textFormat);
            // cNet
            RectangleF r5 = new RectangleF(427, 295, 72, 45);
            e.Graphics.FillRectangle(drawBrushLightGray, 427, 295, 72, 45);

            e.Graphics.DrawRectangle(blackPen, 427, 295, 72, 45);
            e.Graphics.DrawString("Cena netto (PLN)", drawFont, drawBrush, r5, textFormat);
            // wNet
            RectangleF r6 = new RectangleF(499, 295, 72, 45);
            e.Graphics.FillRectangle(drawBrushLightGray, 499, 295, 72, 45);

            e.Graphics.DrawRectangle(blackPen, 499, 295, 72, 45);
            e.Graphics.DrawString("Wartość netto (PLN)", drawFont, drawBrush, r6, textFormat);
            // %
            RectangleF r7 = new RectangleF(571, 295, 24, 45);
            e.Graphics.FillRectangle(drawBrushLightGray, 571, 295, 24, 45);

            e.Graphics.DrawRectangle(blackPen, 571, 295, 24, 45);
            e.Graphics.DrawString("Vat %", drawFont, drawBrush, r7, textFormat);
            // taxVal
            RectangleF r8 = new RectangleF(595, 295, 72, 45);
            e.Graphics.FillRectangle(drawBrushLightGray, 595, 295, 72, 45);

            e.Graphics.DrawRectangle(blackPen, 595, 295, 72, 45);
            e.Graphics.DrawString("Kwota VAT (PLN)", drawFont, drawBrush, r8, textFormat);
            //GrossPr
            RectangleF r9 = new RectangleF(667, 295, 108, 45);
            e.Graphics.FillRectangle(drawBrushLightGray, 667, 295, 108, 45);

            e.Graphics.DrawRectangle(blackPen, 667, 295, 108, 45);
            e.Graphics.DrawString("Wartość brutto (PLN)", drawFont, drawBrush, r9, textFormat);
        }

    }
}
