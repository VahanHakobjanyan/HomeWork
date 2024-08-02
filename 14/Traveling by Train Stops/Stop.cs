using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_by_Train_Stops
{
    internal class Stop
    {
        public string? Station { get; }
        public Cities City { get; }

        public Stop(string? station, Cities city)
        {
            Station = station;
            City = city;
        }

        public override string ToString()
        {
            return $"{Station} station in {City} city";
        }
    }
}
