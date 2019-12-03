using Shopper2019.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Models
{
    public class StockItem : IItem, IStockItemQuantity, INetPrice, IGrossPrice, IStockItem, IVatTaxValue, ITotalGrossPrice, IMeasurements
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal StockQuantity { get; set; }
        public decimal Net_Price { get; set; }
        public decimal Gross_Price { get; set; }
        public int VatValue { get; set; }
        public decimal TotalGross_Price { get; set; }
        public string UnitOfMeasurements { get; set; }
    }
}
