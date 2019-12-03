using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.CurrencyRate.Models
{
    public class CurrencyName : ICurrencyName
    {
        public string[] Names { get; set; } = { "usd", "chf", "eur", "gbp", "cad", "mxn" };
    }
}
