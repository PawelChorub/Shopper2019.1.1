using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Processors
{
    public static class TotalPriceValueProcessor
    {
        public static decimal CalculateTotalPriceValue(decimal quantity, decimal price)
        {
            return quantity * price;
        }
    }
}
