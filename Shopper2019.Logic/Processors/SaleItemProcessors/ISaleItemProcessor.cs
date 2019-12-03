using Shopper2019.Logic.Models;
using System.Collections.Generic;

namespace Shopper2019.Logic.Processors
{
    public interface ISaleItemProcessor
    {
        ISaleItem SetValuesToSaleItem(string code, string name, decimal quantity, string unitOfMeasure, decimal netPrice, int vatTaxValue, decimal grossPrice);
    }
}