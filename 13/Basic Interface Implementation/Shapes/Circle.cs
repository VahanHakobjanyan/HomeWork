using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Interface_Implementation.Shapes
{
    internal class Circle : IShape
    {
        double R { get; set; }

        public Circle(double r) { R = r; }

        public double CalculateArea()
        {
            return 2 * Math.PI * R * R;
        }
    }

}

