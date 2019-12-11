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
    public class SaleBusinessLogic : ISaleBusinessLogic
    {
        IContainer container;
        private ISaleItemProcessor saleItemProcessor;
        private ISaleListItemProcessor saleListItemProcessor;
        private IReadFromStockProcessor readFromStockProcessor;
        private IUpdateStockItemProcessor updateStockItemProcessor;

        public SaleBusinessLogic()
        {
            container = DI_Container.Configure();
            saleItemProcessor = container.Resolve<ISaleItemProcessor>();
            saleListItemProcessor = container.Resolve<ISaleListItemProcessor>();
            readFromStockProcessor = container.Resolve<IReadFromStockProcessor>();
            updateStockItemProcessor = container.Resolve<IUpdateStockItemProcessor>();
        }

        public void NewSaleItemList()
        {
            saleListItemProcessor.CreateNewSaleList();
        }

        public void SendValuesToSaleListItemProcessor(ISaleItem _saleItem)
        {
            if (_saleItem != null)
            {
                saleListItemProcessor.AddItemToSaleList(saleItemProcessor.SetValuesToSaleItem(_saleItem.Code, _saleItem.Name, _saleItem.SaleQuantity, _saleItem.UnitOfMeasurements, _saleItem.Net_Price, _saleItem.VatValue, _saleItem.Gross_Price));
            }
        }

        public List<ISaleItem> ReturnSaleItemList()
        {
            return saleListItemProcessor.ReturnSaleItemList();
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

        public void DeleteItemFromSaleItemList(int index)
        {
            saleListItemProcessor.DeleteSaleItemFromListByIndex(index);
        }

        public void UpdateStockItemQuantityBySaleItemList()
        {
            updateStockItemProcessor.UpdateListToDatabase(saleListItemProcessor.SaleItemList);
        }

        public void UpdateStockItemQuantityByItem(string _code, decimal _quantity)
        {
            updateStockItemProcessor.UpdateStockItemQuantity(_code, _quantity);
        }
    }
}
