using Newtonsoft.Json;
using Shopper2019.CurrencyRate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper2019.CurrencyRate
{
    public class CurrencyRateApiProcessor : ICurrencyRateApiProcessor
    {
        private List<ICurrency> CurrencyRateList { get; set; }
        private ICurrencyName currencyName = new CurrencyName();

        public async Task<List<ICurrency>> GetCurrencyRateList()
        {
            try
            {
                CurrencyRateList = new List<ICurrency>();

                RootObject data;
                for (int i = 0; i < currencyName.Names.Length; i++)
                {
                    using (var httpClient = new HttpClient())
                    {
                        string url = "http://api.nbp.pl/api/exchangerates/rates/a/" + currencyName.Names[i] + "//?format=json";

                        var json = await httpClient.GetStringAsync(url);

                        data = JsonConvert.DeserializeObject<RootObject>(json);

                        CurrencyRateList.Add(new Currency
                        {
                            Name = data.currency.ToString(),
                            Rate = data.rates[0].mid.ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nieudana próba pobrania aktualnych kursów walut. Szczegóły : /n" + ex.ToString());
            }
                return CurrencyRateList;
        }
        //public async void GetCurrencyRate()
        //{
        //    RootObject data;
        //    using (var httpClient = new HttpClient())
        //    {
        //        string url = "http://api.nbp.pl/api/exchangerates/rates/a/usd//?format=json";

        //        var json = await httpClient.GetStringAsync(url);

        //        data = JsonConvert.DeserializeObject<RootObject>(json);
        //    }
        //}
    }
}
