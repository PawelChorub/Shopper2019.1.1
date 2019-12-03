using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Processors
{
    public class StockItemProcessor : IStockItemProcessor
    {
        // dodaj item
        public IStockItem SetValuesToStockItem(string code, string name, decimal quantity, string unitOfMeasurements, decimal netPrice, int vatTaxValue, decimal grossPrice) // grossPrice autoObliczany
        {
            IStockItem stockItem = Factory.CreateStockItem();

            stockItem.Code = code;
            stockItem.Name = name;
            stockItem.StockQuantity = quantity;
            stockItem.UnitOfMeasurements = unitOfMeasurements;
            stockItem.Net_Price = netPrice;
            stockItem.VatValue = vatTaxValue;
            //brutto autoobliczane
            stockItem.Gross_Price = stockItem.Gross_Price = GrossPriceProcessor.GrossPriceCalculate(stockItem.Net_Price, stockItem.VatValue);
            stockItem.TotalGross_Price = TotalPriceValueProcessor.CalculateTotalPriceValue(stockItem.StockQuantity, stockItem.Gross_Price);
            return stockItem;
        }
    }
}
