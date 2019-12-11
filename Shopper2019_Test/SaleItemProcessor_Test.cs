using Moq;
using Shopper2019.Logic.Models;
using Shopper2019.Logic.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shopper2019.Test
{
    public class SaleItemProcessor_Test
    {
        [Theory]
        [InlineData("655", "TestName", 12.34, "szt", 100, 8, 108)]
        [InlineData("601", "TestName2", 11.44, "L", 100.00, 5, 105.00)]
        public void SetValuesToSaleItem_ShouldCreateObject(string _code, string _name, decimal _quantity, string _unitOfMeasure, decimal _netPrice, int _vatTaxValue, decimal _grossPrice)       
        {
            SaleItemProcessor saleItemProcessor = new SaleItemProcessor();

            var actual = saleItemProcessor.SetValuesToSaleItem(_code, _name, _quantity, _unitOfMeasure, _netPrice, _vatTaxValue, _grossPrice);
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("600", "TestName", 34.56, "kg", 200, 8, 216, "TestName")]
        public void SetValuesToSaleItem_ShouldSetObjectProperty_Name_Correctly(string _code, string _name, decimal _quantity, string _unitOfMeasure, decimal _netPrice, int _vatTaxValue, decimal _grossPrice, string expected)
        {
            SaleItemProcessor saleItemProcessor = new SaleItemProcessor();
            ISaleItem item = saleItemProcessor.SetValuesToSaleItem(_code, _name, _quantity, _unitOfMeasure, _netPrice, _vatTaxValue, _grossPrice);

            Assert.EndsWith(item.Name, expected);
        }

        [Theory]
        [InlineData("", "", 0, "", 0, 0, 0)]
        public void SetValuesToSaleItem_ShouldReturnNullCauseOfEmptyInputData(string _code, string _name, decimal _quantity, string _unitOfMeasure, decimal _netPrice, int _vatTaxValue, decimal _grossPrice)
        {
            SaleItemProcessor saleItemProcessor = new SaleItemProcessor();
            ISaleItem item = saleItemProcessor.SetValuesToSaleItem(_code, _name, _quantity, _unitOfMeasure, _netPrice, _vatTaxValue, _grossPrice);

            Assert.Null(item);
        }
    }
}
