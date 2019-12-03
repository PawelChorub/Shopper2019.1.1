using Shopper2019.Logic.Models;

namespace Shopper2019.Logic.Processors
{
    public interface IReadFromStockProcessor
    {
        ISaleItem FindItemInStock(string itemCode);
        ISaleItem CheckExistenceItemInStock(string searchCode, decimal searchQuantity);
    }
}