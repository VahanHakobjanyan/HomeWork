using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MemberwiseClone
{
    class Person
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public Eye Eye { get; set; }
        public Person(string name, byte age, Eye eye)
        {
            Name = name;
            Age = age;
            Eye = eye;  
        }

        public Person MemberwiseCopy()
        {
            return this.MemberwiseClone() as Person;
        }

        public void PrintPerson()
        {
            Console.WriteLine(Name + " " + Age);
        }
    }

    class Eye 
    {
        public string color { get; set; }
    }

}
