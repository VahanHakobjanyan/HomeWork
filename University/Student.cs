using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Interfaces;

namespace University
{
    internal class Student
    {
        public string Name { get; }
        public string Surname { get; }
        public byte Age { get; }

        public string Ssn { get; }
        bool isGraduated;

        public Student(string name, string surname, byte age, string ssn)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Ssn = ssn;
        }
    }
}
