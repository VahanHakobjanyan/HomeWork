using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Circle : Shape
    {
        public double R { get; set; }
        public Circle(double r)
        {
            R = r;
        }

        public override double CalculateArea()
        {
            return 2 * Math.PI * R * R;
        }
    }
}
