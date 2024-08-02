using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Animals.Animals
{
    internal class Lion:Animal
    {
        public Lion(byte age):base(AnimalType.Lion, age) { }
    }
}
