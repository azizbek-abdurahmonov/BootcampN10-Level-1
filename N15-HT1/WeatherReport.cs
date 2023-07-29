using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace N15_HT1
{
    public class WeatherReport
    {
        protected List<DateOnly> dates = new List<DateOnly>();
        protected List<String> weathers = new List<String>();

        private string Find(DateOnly sana)
        {
            for (var i = 0; i < dates.Count; i++)
            {
                if (dates[i] == sana)
                    return weathers[i];
            }

            return null;
        }

        public string Get(DateOnly sana)
        {
            var info = Find(sana);
            return info == null ? "Berilgan kunga ob-havo topilmadi, boshqa kunlar uchun qidiirb ko'ring" : info.ToString();
        }

        public virtual void Add(DateOnly sana, string obhavo)
        {
            dates.Add(sana);
            weathers.Add(obhavo);
        }


    }
}
