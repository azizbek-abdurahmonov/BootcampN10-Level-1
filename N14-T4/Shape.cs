using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14_T4
{
    public class Shape
    {
        public virtual void CalculateArea()
        {
        }
    }

    public class Triangle : Shape
    {
        private double a;

        private double b;

        private double c;


        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void CalculateArea()
        {
            var s = (a + b + c) / 2.0;
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine($"Triangle area : {area}");
        }
    }

    public class Rectangle : Shape
    {
        double _a;
        double _b;
        public Rectangle(double a, double b)
        {
            this._a = a;
            this._b = b;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Rectangle area : {_a * _b}");
        }

    }

    public class Circle : Shape
    {
        double r;
        public Circle(double r)
        {

            this.r = r;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Circle area : {Math.PI * (Math.Pow(r, 2))}");
        }
    }
}
