using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Processors
{
    public class SaleItemProcessor : ISaleItemProcessor
    {
        public ISaleItem SetValuesToSaleItem(string code, string name, decimal quantity, string unitOfMeasure, decimal netPrice, int vatTaxValue, decimal grossPrice) // dane z bazy i ui
        {
            if (code != "" && name != "" && quantity > 0)
            {
                ISaleItem saleItem = Factory.CreateSaleItem();

                saleItem.Code = code;
                saleItem.Name = name;
                saleItem.SaleQuantity = quantity;
                saleItem.VatValue = vatTaxValue;
                saleItem.UnitOfMeasurements = unitOfMeasure;
                saleItem.Net_Price = netPrice;
                saleItem.Gross_Price = grossPrice;

                saleItem.TotalGross_Price = TotalPriceValueProcessor.CalculateTotalPriceValue(saleItem.SaleQuantity, saleItem.Gross_Price);

                return saleItem;
            }
            else
            {
                return null;
            }
        }
    }
}
