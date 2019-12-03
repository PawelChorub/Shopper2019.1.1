using Shopper2019.Logic.Models;

namespace Shopper2019.Logic.Processors
{
    public interface IStockItemProcessor
    {
        IStockItem SetValuesToStockItem(string code, string name, decimal quantity, string unitOfMeasurements, decimal netPrice, int vatTaxValue, decimal grossPrice);
        
    }
}