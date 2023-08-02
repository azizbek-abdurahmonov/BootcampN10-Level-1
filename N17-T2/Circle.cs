using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_T2
{
    internal sealed class Circle : Shape
    {
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
            //throw new NotImplementedException();
        }
    }
}
