using Shopper2019.Logic.Models;
using System.Windows.Forms;

namespace Shopper2019.Logic.Processors.StockItemProcessors
{
    public class StockListViewItemProcessor : IStockListViewItemProcessor
    {
        public int Counter { get; set; } = 1;

        public ListViewItem LoadStockItemsToStockListView(IStockItem stockItem, int counter)
        {
            if (stockItem != null)
            {
                ListViewItem stockList = new ListViewItem(counter.ToString());

                stockList.SubItems.Add(stockItem.Code);
                stockList.SubItems.Add(stockItem.Name);
                stockList.SubItems.Add(stockItem.StockQuantity.ToString("F"));
                stockList.SubItems.Add(stockItem.Net_Price.ToString("F"));
                stockList.SubItems.Add(stockItem.VatValue.ToString());
                stockList.SubItems.Add(stockItem.Gross_Price.ToString("F"));

                return stockList;
            }
            else return null;
        }

        public ListViewItem LoadStockItemsToStockListView2(IStockItem stockItem)
        {
            if (stockItem != null)
            {
                ListViewItem stockListItem = new ListViewItem(Counter.ToString());

                stockListItem.SubItems.Add(stockItem.Code);
                stockListItem.SubItems.Add(stockItem.Name);
                stockListItem.SubItems.Add(stockItem.StockQuantity.ToString("F"));
                stockListItem.SubItems.Add(stockItem.Net_Price.ToString("F"));
                stockListItem.SubItems.Add(stockItem.VatValue.ToString());
                stockListItem.SubItems.Add(stockItem.Gross_Price.ToString("F"));

                Counter++;

                return stockListItem;
            }
            else return null;
        }
    }
}
