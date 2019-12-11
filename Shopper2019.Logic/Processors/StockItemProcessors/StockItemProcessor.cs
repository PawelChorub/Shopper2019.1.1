using Autofac;
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
        IContainer container;
        IStockItem stockItem;

        public StockItemProcessor()
        {
            container = DI_Container.Configure();
        }
        public IStockItem SetValuesToStockItem(string code, string name, decimal quantity, string unitOfMeasurements, decimal netPrice, int vatTaxValue, decimal grossPrice) // grossPrice autoObliczany
        {
            stockItem = container.Resolve<IStockItem>();

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
