using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shopper2019.Logic.Processors;

namespace Shopper2019.Test
{
    public class GrossPriceProcessor_Test
    {
        [Theory]
        [InlineData(100, 23, 123)]
        public void GrossPriceProcessor_ShouldCalculate(decimal netPrice, int vatValue, decimal expected)
        {
            decimal actual = GrossPriceProcessor.GrossPriceCalculate(netPrice, vatValue);
            Assert.Equal(expected, actual);
        }

    }
}
