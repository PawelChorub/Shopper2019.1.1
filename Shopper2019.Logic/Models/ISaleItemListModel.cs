using System.Collections.Generic;

namespace Shopper2019.Logic.Models
{
    public interface ISaleItemListModel
    {
        List<ISaleItem> SaleItemList { get; set; }
    }
}