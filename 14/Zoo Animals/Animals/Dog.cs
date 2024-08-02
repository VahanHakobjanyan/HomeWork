using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Animals.Animals
{
    internal class Dog:Animal
    {
        public Dog(byte age) : base(AnimalType.Dog, age) { }
    }
}
