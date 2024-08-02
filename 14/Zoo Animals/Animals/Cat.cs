using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Animals.Animals
{
    internal class Cat : Animal
    {
        public Cat(byte age) : base(AnimalType.Cat, age) { }
    }
}
