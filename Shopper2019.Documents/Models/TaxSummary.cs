using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.Models
{
    public class TaxSummary
    {
        public decimal _taxFreeSummary { get; set; }
        public decimal _tax5summary { get; set; }
        public decimal _tax8summary { get; set; }
        public decimal _tax23summary { get; set; }
        public decimal _netPrice5summary { get; set; }
        public decimal _netPrice8summary { get; set; }
        public decimal _netPrice23summary { get; set; }
        public decimal _netPriceFreeSummary { get; set; }
        public decimal _grossPrice5summary { get; set; }
        public decimal _grossPrice8summary { get; set; }
        public decimal _grossPrice23summary { get; set; }
        public decimal _grossPriceFreeSummary { get; set; }
    }
}
