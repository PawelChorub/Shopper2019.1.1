using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Processors
{
    public static class TotalPriceValueProcessor // klasa static nie implementuje interfejsu, static!
    {
        // obliczanie wartości na podstawie ilość * podana wartość ( netto lub brutto )
        public static decimal CalculateTotalPriceValue(decimal quantity, decimal price)
        {
            return quantity * price;
        }
    }
}
