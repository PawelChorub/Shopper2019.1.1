using Shopper2019.Documents.View;
using Shopper2019.Logic;
using Shopper2019.Logic.Models;
using Shopper2019.Logic.Processors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper2019.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void StockButton_Click(object sender, EventArgs e)
        {
            StockUI sui = new StockUI();
            sui.Show();
        }

        private void SaleButton_Click(object sender, EventArgs e)
        {
            SaleUI sale = new SaleUI();
            sale.Show();
            CurrencyRateUI currencyRateUI = new CurrencyRateUI();
            currencyRateUI.StartPosition = FormStartPosition.Manual;
            currencyRateUI.Location = new Point(6, 10);
            currencyRateUI.Show();
            
        }

        private void StockItemsBtn_Click(object sender, EventArgs e)
        {
            StockUI_ItemsView stock = new StockUI_ItemsView();
            stock.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceDocumentNew inv = new InvoiceDocumentNew();
            inv.Show();
        }
    }
}
