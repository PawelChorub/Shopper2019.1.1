using Autofac;
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
        IContainer container;
        private IStockItemProcessor stockItemProcessor;
        private IStockListItemProcessor stockListItemProcessor;
        private ISaveToStockProcessor saveToStockProcessor;
        private IReadFromStockProcessor readFromStockProcessor;
        private IUpdateStockItemProcessor updateStockItemProcessor;

        public StockBusinessLogic()
        {
            container = DI_Container.Configure();
            stockItemProcessor = container.Resolve<IStockItemProcessor>();
            stockListItemProcessor = container.Resolve<IStockListItemProcessor>();
            saveToStockProcessor = container.Resolve<ISaveToStockProcessor>();
            readFromStockProcessor = container.Resolve<IReadFromStockProcessor>();
            updateStockItemProcessor = container.Resolve<IUpdateStockItemProcessor>();
        }

        public void SendValuesToStockListItemProcessor(string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice)
        {
            Decimal.TryParse(quantity, out decimal q);
            Decimal.TryParse(netPrice, out decimal net);
            Int32.TryParse(vatTaxValue, out int tax);
            Int32.TryParse(grossPrice, out int gross);

            stockListItemProcessor.AddItemToStockList(stockItemProcessor.SetValuesToStockItem(code, name, q, unitOfMeasurement, net, tax, gross));
        }

        public List<IStockItem> ReturnStockItem_List()
        {
            return stockListItemProcessor.ReturnStockItemList();
        }

        public void NewStockItemList()
        {
            stockListItemProcessor.CreateNewList();
        }

        public void DeleteStockItemListByIndex(int index)
        {
            stockListItemProcessor.DeleteStockItemFromListByIndex(index);
        }

        public void EditItemFromListByIndex(int index, string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice)
        {
            Decimal.TryParse(quantity, out decimal q);
            Decimal.TryParse(netPrice, out decimal net);
            Int32.TryParse(vatTaxValue, out int tax);
            Int32.TryParse(grossPrice, out int gross);
            stockListItemProcessor.EditStockItemListElement(stockListItemProcessor.StockItemList, stockItemProcessor.SetValuesToStockItem(code, name, q, unitOfMeasurement, net, tax, gross), index);
        }

        public void SaveToStock(string code, string name, string quantity, string unitOfMeasurement, string netPrice, string vatTaxValue, string grossPrice)
        {
            Decimal.TryParse(quantity, out decimal q);
            Decimal.TryParse(netPrice, out decimal net);
            Int32.TryParse(vatTaxValue, out int tax);
            Int32.TryParse(grossPrice, out int gross);

            saveToStockProcessor.SaveItemToStock(stockItemProcessor.SetValuesToStockItem(code, name, q, unitOfMeasurement, net, tax, gross));
        }
        public void SaveStockItemsToSql()
        {
            stockListItemProcessor.SaveListToDatabase(stockListItemProcessor.ReturnStockItemList());
        }

        public ISaleItem ReturnSaleItemFromStock(string code)
        {
            return readFromStockProcessor.FindItemInStock(code);
        }
        
        public ISaleItem CheckSaleItemExists(string code, string quantity)
        {
            bool success = Decimal.TryParse(quantity, out decimal result);

            if (readFromStockProcessor.CheckExistenceItemInStock(code, result) != null)
            {
                return readFromStockProcessor.CheckExistenceItemInStock(code, result);
            }
            else
            {
                return null;
            }
        }

        public void UpdateIncreaseStockItemQuantity(string code, string quantity)
        {
            Decimal.TryParse(quantity, out decimal result);

            updateStockItemProcessor.IncreaseStockItemQuantity(code, result);
        }

    }
}
