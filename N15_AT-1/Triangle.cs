using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_AT_1
{
    internal class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (!isValid(a, b, c))
                throw new ArgumentException("Triangle isn't valid!");

            A = a;
            B = b;
            C = c;
        }

        public double Perimetr { get => A + B + C; }
        public double Area
        {
            get
            {
                var p = Perimetr / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        private bool isValid(double a, double b, double c)
        {
            return a < b + c && b < c + a && c < a + b;
        }
    }
}
