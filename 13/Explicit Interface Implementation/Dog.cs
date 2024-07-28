using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface_Implementation
{
    internal class Dog : IAnimal
    {
        void IAnimal.Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        void IAnimal.Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
    }
}
