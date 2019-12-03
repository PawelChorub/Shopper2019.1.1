using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Test
{
    class MockSaleItem : ISaleItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal SaleQuantity { get; set; }
        public decimal Net_Price { get; set; }
        public decimal Gross_Price { get; set; }
        public decimal TotalGross_Price { get; set; }
        public int VatValue { get; set; }
        public string UnitOfMeasurements { get; set; }

        public MockSaleItem(string code, string name, decimal saleQuantity, decimal net_Price, 
            decimal gross_Price, decimal totalGrossPrice, int vatValue, string unitOfMeasurement)
        {
            Code = code;
            Name = name;
            SaleQuantity = saleQuantity;
            net_Price = Net_Price;
            Gross_Price = gross_Price;
            TotalGross_Price = totalGrossPrice;
            VatValue = vatValue;
            UnitOfMeasurements = unitOfMeasurement;
        }
        

    }
}
