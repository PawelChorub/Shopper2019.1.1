using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.CurrencyRate.Models
{
    public class Currency : ICurrency
    {
        public string Name { get; set; }
        public string Rate { get; set; }
    }
}
