using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface_Implementation
{
    internal interface IAnimal
    {
        void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }
}
