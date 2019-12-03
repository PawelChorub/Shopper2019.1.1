using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shopper2019.Documents
{
    public partial class ReceiptDocument : Form
    {

        public ReceiptDocument()
        {
            InitializeComponent();
        }

        public string SetReceiptDetails(string details)
        {
            return label1.Text = details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialogReceipt.Document = printDocumentReceipt;
            printPreviewDialogReceipt.Show();
        }        

        private void printDocumentReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Point p1 = new Point(10,10);
            e.Graphics.DrawString(label1.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, p1);
        }

        private void printPreviewDialogReceipt_Load(object sender, EventArgs e)
        {           
        }
    }
}
