using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N15_HT1;

namespace N15_HT1
{
    internal class UltimateWeatherReport : ValidatedWeahterReport
    {
        public Dictionary<DateOnly, string> Get(DateOnly sana, int kun) 
        {
            Sort(dates, weathers);
            var index = dates.IndexOf(sana);
            var days = dates.Count - index;
            var dict = new Dictionary<DateOnly, string>();

            if (days < kun)
            {
                Console.WriteLine("Uzr, to'liq ma'lumot yo'q");
                return dict;
            }

            for (var i = index; i < kun + index; i++)
            {
                dict[dates[i]] = weathers[i];
            }

            return dict;
        }

        public Dictionary<DateOnly, string> Get(int kun)
        {
            Sort(dates, weathers);
            var index = dates.IndexOf(DateOnly.FromDateTime(DateTime.Now));
            var days = dates.Count - index;
            var dict = new Dictionary<DateOnly, string>();

            if (days < kun)
            {
                Console.WriteLine("Uzr, to'liq ma'lumot yo'q");
                return dict;
            }

            for (var i = index; i < kun + index; i++)
            {
                dict[dates[i]] = weathers[i];
            }

            return dict;
        }

        public void Sort(List<DateOnly> dates, List<string> weathers)
        {
            for (var i = 0; i < dates.Count; i++)
            {
                for (var j = 0; j < weathers.Count; j++)
                {
                    if (dates[i] < dates[j])
                    {
                        var temp = dates[i];
                        dates[i] = dates[j];
                        dates[j] = temp;

                        var temp2 = weathers[i];
                        weathers[i] = weathers[j];
                        weathers[j] = temp2;
                    }
                }
            }



        }
    }
}
