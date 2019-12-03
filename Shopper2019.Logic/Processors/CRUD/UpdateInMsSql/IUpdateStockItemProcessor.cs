using Shopper2019.Logic.Models;

namespace Shopper2019.Logic.Processors.UpdateInMsSql
{
    public interface IUpdateStockItemProcessor
    {
        void UpdateListToDatabase(System.Collections.Generic.List<ISaleItem> listName);
        void UpdateStockItemQuantity(string code, decimal quantity);
        void IncreaseStockItemQuantity(string code, decimal quantity);
    }
}