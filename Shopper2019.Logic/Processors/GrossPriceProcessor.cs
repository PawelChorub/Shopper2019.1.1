﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Processors
{
    public class GrossPriceProcessor
    {
        public static decimal GrossPriceCalculate(decimal netPrice, int vatValue)
        {
            decimal GrossPrice = netPrice + ((netPrice / 100) * vatValue);

            return GrossPrice;
        }
    }
}
