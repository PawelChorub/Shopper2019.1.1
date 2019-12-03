using System.Collections.Generic;

namespace Shopper2019.Logic.Models
{
    public interface IStockItemListModel
    {
        List<IStockItem> StockItemList { get; set; }
    }
}