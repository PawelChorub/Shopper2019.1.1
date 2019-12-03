using System.Windows.Forms;
using Shopper2019.Logic.Models;

namespace Shopper2019.Logic.Processors.StockItemProcessors
{
    public interface IStockListViewItemProcessor
    {
        ListViewItem LoadStockItemsToStockListView(IStockItem stockItem, int counter);
        ListViewItem LoadStockItemsToStockListView2(IStockItem stockItem);
    }
    
}