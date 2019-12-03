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
    public partial class StockUI_ItemsView : Form
    {
        public StockUI_ItemsView()
        {
            InitializeComponent();
        }

        private void StockUI_ItemsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopper2019DbDataSet.Shopper2019StockTable' table. You can move, or remove it, as needed.
            this.shopper2019StockTableTableAdapter.Fill(this.shopper2019DbDataSet.Shopper2019StockTable);

        }
    }
}
