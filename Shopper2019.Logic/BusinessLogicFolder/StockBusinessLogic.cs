using Shopper2019.Logic.Models;
using Shopper2019.Logic.Processors;
using Shopper2019.Logic.Processors.UpdateInMsSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.BusinessLogicFolder
{
    public class StockBusinessLogic : IStockBusinessLogic
    {
        private IStockItemProcessor sip = Factory.CreateStockItemProcessor();
        private IStockListItemProcessor slip = Factory.CreateStockListItemProcessor();

        public void SendValuesToStockListItemProcessor(string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice)
        {
            Decimal.TryParse(quantity, out decimal q);
            Decimal.TryParse(netPrice, out decimal net);
            Int32.TryParse(vatTaxValue, out int tax);
            Int32.TryParse(grossPrice, out int gross);

            slip.AddItemToStockListVoid(sip.SetValuesToStockItem(code, name, q, unitOfMeasurement, net, tax, gross));
        }
        public List<IStockItem> ReturnStockItem_List()
        {
            return slip.ReturnStockItemList();
        }
        public void NewStockItemList()
        {
            slip.CreateNewList();
        }
        public void DeleteStockItemListByIndex(int index)
        {

            slip.DeleteStockItemFromListByIndex(index);
        }
        public void EditItemFromListByIndex(int index, string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice)
        {
            Decimal.TryParse(quantity, out decimal q);
            Decimal.TryParse(netPrice, out decimal net);
            Int32.TryParse(vatTaxValue, out int tax);
            Int32.TryParse(grossPrice, out int gross);
            slip.EditStockItemListElement(slip.StockItemList, sip.SetValuesToStockItem(code, name, q, unitOfMeasurement, net, tax, gross), index);
        }
        private ISaveToStockProcessor saveItemToStock = Factory.CreateSaveToStockProcessor();

        public void SaveToStock(string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice)
        {
            Decimal.TryParse(quantity, out decimal q);
            Decimal.TryParse(netPrice, out decimal net);
            Int32.TryParse(vatTaxValue, out int tax);
            Int32.TryParse(grossPrice, out int gross);

            saveItemToStock.SaveItemToSqlStock(sip.SetValuesToStockItem(code, name, q, unitOfMeasurement, net, tax, gross));
        }
        public void SaveStockItemsToSql()
        {
            //slip.SaveListToDatabase(slip.StockItemList);
            slip.SaveListToDatabase(slip.ReturnStockItemList());
        }
        private IReadFromStockProcessor rfs = Factory.CreateReadFromStockProcessor();
        public ISaleItem ReturnSaleItemFromStock(string code)
        {
            return rfs.FindItemInStock(code);
        }
        
        public ISaleItem CheckSaleItemExists(string code, string quantity)
        {
            bool success = Decimal.TryParse(quantity, out decimal result);

            if (rfs.CheckExistenceItemInStock(code, result) != null)
            {
                return rfs.CheckExistenceItemInStock(code, result);
            }
            else
            {
                return null;
            }
        }
        private IUpdateStockItemProcessor usip = Factory.CreateUpdateStockItemProcessor();
        public void UpdateIncreaseStockItemQuantity(string code, string quantity)
        {
            Decimal.TryParse(quantity, out decimal result);

            usip.IncreaseStockItemQuantity(code, result);
        }

    }
}
