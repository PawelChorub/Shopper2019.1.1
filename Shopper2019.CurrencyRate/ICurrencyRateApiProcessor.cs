using System.Collections.Generic;
using System.Threading.Tasks;
using Shopper2019.CurrencyRate.Models;

namespace Shopper2019.CurrencyRate
{
    public interface ICurrencyRateApiProcessor
    {
        Task<List<ICurrency>> GetCurrencyRateList();
    }
}