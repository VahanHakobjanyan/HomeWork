using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepClone
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
        private Person(Person sourcePerson)
        {
            Name = sourcePerson.Name;
            Age = sourcePerson.Age;
            Eye = new Eye() { color = sourcePerson.Eye.color };
        }

        public Person DeepCopy()
        {
            return new Person(this);
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
