﻿using Autofac;
using Shopper2019.Logic.Models;

namespace Shopper2019.Logic.Processors
{
    public class SaleItemProcessor : ISaleItemProcessor
    {
        IContainer container;
        ISaleItem saleItem;

        public SaleItemProcessor()
        {
            container = DI_Container.Configure();
        }

        public ISaleItem SetValuesToSaleItem(string code, string name, decimal quantity, string unitOfMeasure, decimal netPrice, int vatTaxValue, decimal grossPrice) // dane z bazy i ui
        {
            if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(name) && quantity > 0)
            {
                saleItem = container.Resolve<ISaleItem>();

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
