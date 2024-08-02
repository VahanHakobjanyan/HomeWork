using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Animals.Animals
{
    internal class Bear : Animal
    {
        public Bear(byte age) : base(AnimalType.Bear, age) { }
    }
}
