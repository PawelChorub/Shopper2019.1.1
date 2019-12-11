using Shopper2019.Logic.Models;
using System.Collections.Generic;

namespace Shopper2019.Logic.BusinessLogicFolder
{
    public interface ISaleBusinessLogic
    {
        void NewSaleItemList();
        void SendValuesToSaleListItemProcessor(ISaleItem _saleItem);
        ISaleItem ReturnSaleItemFromStock(string code);
        ISaleItem CheckSaleItemExists(string code, string quantity);
        List<ISaleItem> ReturnSaleItemList();
        void DeleteItemFromSaleItemList(int index);
        void UpdateStockItemQuantityBySaleItemList();
        void UpdateStockItemQuantityByItem(string _code, decimal _quantity);
    }
}