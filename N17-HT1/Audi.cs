using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1
{
    internal sealed class Audi : CarRental
    {
        public string ModelName { get; set; }
        public const int RentPricePerHour = 20;


        public Audi(string modelname)
        {
            this.ModelName = modelname;
            this.BrandName = "AUDI";
        }
    }
}
