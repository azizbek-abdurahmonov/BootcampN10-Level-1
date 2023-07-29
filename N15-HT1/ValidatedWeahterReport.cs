using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace N15_HT1
{
    public class ValidatedWeahterReport : WeatherReport
    {
        public override void Add(DateOnly sana, string obhavo)
        {
            var have = false;
            for (var i = 0; i < dates.Count; i++)
            {
                if (dates[i] == sana)
                {
                    have = true;
                    weathers[i] = obhavo;
                    break;
                }
            }

            if (!have)
            {
                dates.Add(sana);
                weathers.Add(obhavo);
            }

        }


        //temp methods
        public void Display()
        {
            for (var i = 0; i < weathers.Count; i++)
            {
                Console.WriteLine($"{dates[i]} - {weathers[i]}");
            }
        }
    }
}
