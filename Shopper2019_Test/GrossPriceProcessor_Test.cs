using Shopper2019.Logic.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shopper2019.Test
{
    public class GrossPriceProcessor_Test
    {
        [Theory]
        [InlineData(100, 23, 123)]
        [InlineData(100, 8, 108)]
        [InlineData(100, 5, 105)]
        public void GrossPriceProcessor_ShouldCalculate(decimal _netPrice, int _vatValue, decimal expected)
        {
            decimal actual = GrossPriceProcessor.GrossPriceCalculate(_netPrice, _vatValue);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GrossPriceProcessor_ShouldCalculate_InFact()
        {
            decimal actual = GrossPriceProcessor.GrossPriceCalculate(100, 23);
            decimal expected = 123;
            Assert.Equal(expected, actual);
        }
    }
}
