using System.Collections.Generic;
using System.Windows.Forms;
using Shopper2019.Logic.Models;

namespace Shopper2019.Logic
{
    public interface IBusinessLogic
    {
        //ISaleItem CheckSaleItemExists(string code, string quantity);
        //void DeleteFromSaleItemList(string itemCode);
        //void DeleteFromStockItemList(string itemCode);
        //void DeleteStockItemListByIndex(int index);
        //void NewSaleItemList();
        //void NewStockItemList();
        //ISaleItem ReturnSaleItemFromStock(string code);
        //IStockItem ReturnStockItem(string code, string name, string quantity, string netPrice, string vatTaxValue, string grossPrice);
        //List<IStockItem> ReturnStockItem_List();
        //void SaveStockItemsToSql();
        //void SaveToStock(string code, string name, string quantity, string netPrice, string vatTaxValue, string grossPrice);
        //void SendValuesToSaleItemProcessor(string code, string name, string saleQty, string grossPrice, string vatTaxValue);
        //void SendValuesToSaleListItemProcessor(ISaleItem _saleItem);
        //ListViewItem SendValuesToSaleListViewItem(ISaleItem item);
        //void SendValuesToStockItemProcessor(string code, string name, string quantity, string netPrice, string vatTaxValue, string grossPrice);
        //void SendValuesToStockListItemProcessor(string code, string name, string quantity, string netPrice, string vatTaxValue, string grossPrice);
        //ListViewItem SendValuesToStockListViewItem(IStockItem item, int counter);
        //void UpdateListStockQuantity();
        //void UpdateStockQuantity(string _code, string _quantity);
        //string ViewSaleItemList();
        //void EditItemFromListByIndex(int index, string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice);

        //void UpdateStockItemQuantityByItem(string _code, double _quantity);
        //void UpdateIncreaseStockItemQuantity(string code, string quantity);
    }
}