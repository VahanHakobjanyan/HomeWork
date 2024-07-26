using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Rectangle : Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Rectangle(double x, double y)
        {
            X = x; Y = y;
        }

        public override double CalculateArea()
        {
            return X * Y;
        }
    }
}
