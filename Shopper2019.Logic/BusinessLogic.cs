using Shopper2019.Logic.Models;
using Shopper2019.Logic.Processors;
using Shopper2019.Logic.Processors.SaleItemProcessors;
using Shopper2019.Logic.Processors.StockItemProcessors;
using Shopper2019.Logic.Processors.UpdateInMsSql;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper2019.Logic
{
    public class BusinessLogic : IBusinessLogic
    {
        //// wyodrębnić na kontrolery elementy stockItem itd
        //// albo na różne businessL. StockBusinessL, saleits
        //IStockItemProcessor sip = Factory.CreateStockItemProcessor();
        //IStockListItemProcessor slip = Factory.CreateStockListItemProcessor();
        //// prześlij wartości do obiektu

        //public void SendValuesToStockItemProcessor(string code, string name, string quantity, string netPrice, string vatTaxValue, string grossPrice)
        //{         
        //   Double.TryParse(quantity, out double q);
        //   Double.TryParse(netPrice, out double net);
        //   Int32.TryParse(vatTaxValue, out int tax);
        //   Int32.TryParse(grossPrice, out int gross);

        //    sip.SetValuesToStockItem(code, name, q, net, tax, gross);
        //}
        ////prześlij wartości do obiektu listy
        ////pusty void
        ////zostaje+++******
        //public void SendValuesToStockListItemProcessor(string code, string name, string quantity, string netPrice, string vatTaxValue, string grossPrice)
        //{
        //    Double.TryParse(quantity, out double q);           
        //    Double.TryParse(netPrice, out double net);           
        //    Int32.TryParse(vatTaxValue, out int tax);      
        //    Int32.TryParse(grossPrice, out int gross);

        //    slip.AddItemToStockListVoid(sip.SetValuesToStockItem(code, name, q, net, tax, gross));          
        //}

        //// to samo co wyżej tylko return! zwraca gotowy obiekt!
        //public IStockItem ReturnStockItem(string code, string name, string quantity, string netPrice, string vatTaxValue, string grossPrice)
        //{
        //    Double.TryParse(quantity, out double q);
        //    Double.TryParse(netPrice, out double net);
        //    Int32.TryParse(vatTaxValue, out int tax);
        //    Int32.TryParse(grossPrice, out int gross);

        //    return sip.SetValuesToStockItem(code, name, q, net, tax, gross);
        //}
        ////zostaje+++****
        //public List<IStockItem> ReturnStockItem_List()
        //{
        //    return slip.ReturnStockItemList();
        //}
        //// nowa lista
        ////zostaje+++***
        //public void NewStockItemList()
        //{
        //    slip.CreateNewList();
        //}

        //public void DeleteFromStockItemList(string itemCode)
        //{
        //    slip.DeleteStockItemFromList(itemCode);
        //}
        ////zostaje+++***
        //public void DeleteStockItemListByIndex(int index)
        //{
        
        //        slip.DeleteStockItemFromListByIndex(index);
        //}
        ////zostajje++++***
        //public void EditItemFromListByIndex(int index, string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice)
        //{
        //    Double.TryParse(quantity, out double q);
        //    Double.TryParse(netPrice, out double net);
        //    Int32.TryParse(vatTaxValue, out int tax);
        //    Int32.TryParse(grossPrice, out int gross);
        //    slip.EditStockItemListElement(slip.StockItemList, sip.SetValuesToStockItem(code, name, q, unitOfMeasurement, net, tax, gross), index);
        //}

        ////-------------------------------sale

        //ISaleItemProcessor saleItem = Factory.CreateSaleItemProcessor();
        //ISaleListItemProcessor saleListItem = Factory.CreateSaleListItemProcessor();

        //public void SendValuesToSaleItemProcessor(string code, string name, string saleQty, string grossPrice, string vatTaxValue)
        //{
        //    Double.TryParse(saleQty, out double q);
        //    Int32.TryParse(vatTaxValue, out int tax);
        //    Int32.TryParse(grossPrice, out int gross);
        //    saleItem.SetValuesToSaleItem(code, name, q, tax, gross);
        //}
        ////OK
        //public void SendValuesToSaleListItemProcessor(ISaleItem _saleItem)
        //{          
        //    saleListItem.AddItemToSaleList(saleItem.SetValuesToSaleItem(_saleItem.Code, _saleItem.Name, _saleItem.SaleQuantity, _saleItem.VatValue, _saleItem.Gross_Price));
        //}
        ////OK
        //public void NewSaleItemList()
        //{
        //    saleListItem.CreateNewSaleList();
        //}

        //public string ViewSaleItemList()
        //{
        //    return saleListItem.ViewListSaleItem(saleListItem.SaleItemList);
        //}

        //public void DeleteFromSaleItemList(string itemCode)
        //{
        //    saleListItem.DeleteSaleItemFromList(itemCode);
        //}

        //ISaveToStockProcessor saveItemToStock = Factory.CreateSaveToStockProcessor();
        ////zostaje+++***
        //public void SaveToStock(string code, string name, string quantity, string netPrice, string vatTaxValue, string grossPrice)
        //{
        //    Double.TryParse(quantity, out double q);
        //    Double.TryParse(netPrice, out double net);
        //    Int32.TryParse(vatTaxValue, out int tax);
        //    Int32.TryParse(grossPrice, out int gross);

        //    saveItemToStock.SaveItemToSqlStock(sip.SetValuesToStockItem(code, name, q, net, tax, gross));
        //}

        //IStockListViewItemProcessor lvi = Factory.CreateStockListViewItemProcessor();

        //public ListViewItem SendValuesToStockListViewItem(IStockItem item, int counter)
        //{
        //    return lvi.LoadStockItemsToStockListView(item, counter);
        //}

        ////zostaje+++***
        //public void SaveStockItemsToSql()
        //{
        //    //slip.SaveListToDatabase(slip.StockItemList);
        //    slip.SaveListToDatabase(slip.ReturnStockItemList());
        //}
        ////---------------------------------------Sale

        //ISaleListViewItemProcessor salevi = Factory.CreateSaleListViewItemProcessor();

        //public ListViewItem SendValuesToSaleListViewItem(ISaleItem item)
        //{
        //    return salevi.LoadSaleItemsToSaleListView(item);
        //}

        //IReadFromStockProcessor rfs = Factory.CreateReadFromStockProcessor();

        //// poniżej chyba do usunięcia
        ////public void ReadFromStock(string item_Code, string item_SearchQuantity)
        ////{
        ////    rfs.FindItemInStock(item_Code, item_SearchQuantity);
        ////}

        ////zostaje+++***
        //public ISaleItem ReturnSaleItemFromStock(string code)
        //{
        //    return rfs.FindItemInStock(code);
        //}
        ////zostaje+++***
        //public ISaleItem CheckSaleItemExists(string code, string quantity)
        //{
        //    bool success = Double.TryParse(quantity, out double result);

        //    if (rfs.CheckExistenceItemInStock(code, result) != null)
        //    {
        //        return rfs.CheckExistenceItemInStock(code, result);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //IUpdateStockItemProcessor usip = Factory.CreateUpdateStockItemProcessor();

        //public void UpdateStockQuantity(string _code, string _quantity)
        //{
        //    bool success = Double.TryParse(_quantity, out double result);

        //    usip.UpdateStockItemQuantity(_code, result);
        //}
        ////zostaje+++***
        //public void UpdateIncreaseStockItemQuantity(string code, string quantity)
        //{
        //    Double.TryParse(quantity, out double result);

        //    usip.IncreaseStockItemQuantity(code, result);
        //}

        //public void UpdateListStockQuantity()
        //{
        //    usip.UpdateListToDatabase(saleListItem.SaleItemList);
        //}
        //public void UpdateStockItemQuantityByItem(string _code, double _quantity)
        //{
        //    usip.UpdateStockItemQuantity(_code, _quantity);
        //}
    }   
}
