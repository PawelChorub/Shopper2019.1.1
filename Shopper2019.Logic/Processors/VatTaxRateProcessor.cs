using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Processors
{
    public class VatTaxRateProcessor : IVatTaxRateProcessor
    {
        public int Vat5 { get; set; } = 5;
        public int Vat8 { get; set; } = 8;
        public int Vat23 { get; set; } = 23;
    }
}
