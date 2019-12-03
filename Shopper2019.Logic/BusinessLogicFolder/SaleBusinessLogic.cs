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
        private ISaleItemProcessor sip = Factory.CreateSaleItemProcessor();
        private ISaleListItemProcessor slip = Factory.CreateSaleListItemProcessor();
        private IReadFromStockProcessor rfs = Factory.CreateReadFromStockProcessor();
        private IUpdateStockItemProcessor usip = Factory.CreateUpdateStockItemProcessor();

        public void NewSaleItemList()
        {
            slip.CreateNewSaleList();
        }
        public void SendValuesToSaleListItemProcessor(ISaleItem _saleItem)
        {
            if (_saleItem != null)
            {
                slip.AddItemToSaleList(sip.SetValuesToSaleItem(_saleItem.Code, _saleItem.Name, _saleItem.SaleQuantity, _saleItem.UnitOfMeasurements, _saleItem.Net_Price, _saleItem.VatValue, _saleItem.Gross_Price));
            }
        }
        public List<ISaleItem> ReturnSaleItemList()
        {
            return slip.ReturnSaleItemList();
        }
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
        //wyrzuć!
        public bool CheckSaleItemExistsBoolTest(string code, string quantity)
        {
            Decimal.TryParse(quantity, out decimal result);

            if (rfs.CheckExistenceItemInStock(code, result) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeleteItemFromSaleItemList(int index)
        {
            slip.DeleteSaleItemFromListByIndex(index);
        }

        public void UpdateStockItemQuantityBySaleItemList()
        {
            usip.UpdateListToDatabase(slip.SaleItemList);
        }

        public void UpdateStockItemQuantityByItem(string _code, decimal _quantity)
        {
            usip.UpdateStockItemQuantity(_code, _quantity);
        }
    }
}
