using System.Windows.Forms;
using Shopper2019.Logic.Models;

namespace Shopper2019.Logic.Processors.SaleItemProcessors
{
    public interface ISaleListViewItemProcessor
    {
        ListViewItem LoadSaleItemsToSaleListView(ISaleItem saleItem);
    }
}