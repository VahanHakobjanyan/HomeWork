using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog does Woof Woof");
        }
    }
}
