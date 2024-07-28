using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Interface_Implementation.Shapes
{
    internal class Triangle : IShape
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > c))
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                Console.WriteLine("Sum of two sides of triangle must be bigger than third side");
                Console.WriteLine("Try again");
                new Triangle(A, B, C);
            }
        }

        public double CalculateArea()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - A) * (s - C));
        }

    }
}
