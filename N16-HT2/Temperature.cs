using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16_HT2
{
    internal class Temperature
    {
        public float Expected;
        public float Current;

        public Temperature(float expected, float current)
        {
            this.Expected = expected;
            this.Current = current;
        }
    }
}
