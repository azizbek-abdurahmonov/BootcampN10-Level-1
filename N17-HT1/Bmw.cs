using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1
{
    internal sealed class Bmw : CarRental
    {
        public string ModelName { get; set; }
        public const int RentPricePerHour = 30;

        public Bmw(string modelname)
        {
            this.ModelName = modelname;
            this.BrandName = "BMW";
        }

    }
}
