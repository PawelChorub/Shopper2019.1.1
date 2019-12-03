using Shopper2019.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Models
{
    public class SaleItem : IItem, ISaleItemQuantity, IGrossPrice, IVatTaxValue, ITotalGrossPrice, INetPrice, IMeasurements, ISaleItem
    {
        public decimal Gross_Price { get; set; }
        public decimal SaleQuantity { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int VatValue { get; set; }
        public decimal TotalGross_Price { get; set; }
        public decimal Net_Price { get; set; }
        public string UnitOfMeasurements { get; set; }
    }
}
