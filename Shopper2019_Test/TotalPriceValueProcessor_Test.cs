using Shopper2019.Logic.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shopper2019.Test
{
    public class TotalPriceValueProcessor_Test
    {
        [Theory]
        [InlineData(13.01, 25, 325.25)]
        [InlineData(21.25, 3.65, 77.56)]
        [InlineData(2569.369, 235.478, 605029.87)]
        public void CalculateTotalPriceValue_ShouldCalculateInPrecisionOfDecimalPlacesTwo(decimal _quantity, decimal _price, decimal expected)
        {
            decimal actual = TotalPriceValueProcessor.CalculateTotalPriceValue(_quantity, _price);

            Assert.Equal(expected, actual, 2);
        }
    }
}
