using System.Collections.Generic;
using Shopper2019.Logic.Models;

namespace Shopper2019.Logic.Processors
{
    public interface IStockListItemProcessor
    {
        List<IStockItem> StockItemList { get; set; }

        void AddItemToStockListVoid(IStockItem item);
        void CreateNewList();
        void DeleteStockItemFromList(string code);
        void DeleteStockItemFromListByIndex(int index);
        List<IStockItem> ReturnStockItemList();
        void SaveListToDatabase(List<IStockItem> listName);
        //void SaveStockItemToStock(IStockItem item);

        void EditStockItemListElement(List<IStockItem> listName, IStockItem stockItem, int index);
    }
}