using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Animals.Animals
{
    abstract class Animal
    {
        public AnimalType Type { get; }
        public byte Age { get; }

        public Animal(AnimalType animal, byte age)
        {
            Type = animal;
            Age = age;
        }

        public override string ToString()
        {
            return $"Animal type - {Type}, Age - {Age}";
        }
    }
}
