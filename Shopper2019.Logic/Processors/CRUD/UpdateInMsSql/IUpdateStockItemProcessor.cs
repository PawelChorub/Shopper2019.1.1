using Shopper2019.Logic.Models;

namespace Shopper2019.Logic.Processors.UpdateInMsSql
{
    public interface IUpdateStockItemProcessor
    {
        void DecreaseSaleItemListToDatabase(System.Collections.Generic.List<ISaleItem> listName);
        void DecreaseStockItemQuantity(string code, decimal quantity);
        void IncreaseStockItemQuantity(string code, decimal quantity);
    }
}