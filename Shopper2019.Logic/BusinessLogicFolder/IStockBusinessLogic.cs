using System.Collections.Generic;
using Shopper2019.Logic.Models;

namespace Shopper2019.Logic.BusinessLogicFolder
{
    public interface IStockBusinessLogic
    {
        ISaleItem CheckSaleItemExists(string code, string quantity);
        void DeleteStockItemListByIndex(int index);
        void EditItemFromListByIndex(int index, string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice);
        void NewStockItemList();
        ISaleItem ReturnSaleItemFromStock(string code);
        List<IStockItem> ReturnStockItem_List();
        void SaveStockItemsToSql();
        void SaveToStock(string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice);
        void SendValuesToStockListItemProcessor(string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice);
        void UpdateIncreaseStockItemQuantity(string code, string quantity);
    }
}