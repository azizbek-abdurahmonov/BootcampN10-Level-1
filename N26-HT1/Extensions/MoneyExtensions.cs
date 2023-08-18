using N26_HT1.Enums;
using N26_HT1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace N26_HT1.Extensions
{
    internal static class MoneyExtensions
    {
        public static async Task<decimal>? ToUZS(this Money money)
        {
            if (money.Currency == Currency.UZS) return money.Amount;

            if (money.Currency == Currency.RUB)
            {
                using var client = new HttpClient();
                var apiUrl = "https://cbu.uz/uz/arkhiv-kursov-valyut/json/";
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<List<RateUzs>>(responseBody);

                    return Convert.ToDecimal(obj.Find(x => x.Ccy == money.Currency.ToString()).Rate) * money.Amount;
                }
                else
                    throw new Exception("API is not working");
            }

            if (money.Currency == Currency.USD)
            {
                using var client = new HttpClient();
                var apiUrl = "https://cbu.uz/uz/arkhiv-kursov-valyut/json/";
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<List<RateUzs>>(responseBody);

                    return Convert.ToDecimal(obj.Find(x => x.Ccy == money.Currency.ToString()).Rate) * money.Amount;
                }
                else
                    throw new Exception("API is not working");
            }

            return default(decimal);
        }
    }
}
