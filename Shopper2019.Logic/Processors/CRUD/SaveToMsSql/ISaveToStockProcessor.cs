using Shopper2019.Logic.Models;
using System.Collections.Generic;

namespace Shopper2019.Logic.Processors
{
    public interface ISaveToStockProcessor
    {
        //void SaveItemToSqlStock(string code, string name, string quantity, string netPrice, string vatTax, string grossPrice);
        void SaveItemToSqlStock(IStockItem saveItem);
       

    }
}