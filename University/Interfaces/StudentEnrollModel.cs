using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Interfaces
{
    internal class StudentEnrollModel
    {
        public string Name { get; }
        public string Surname { get; }
        public byte Age { get; }
        public string Ssn { get; }

        public StudentEnrollModel(string name, string surname, byte age, string ssn)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Ssn = ssn;
        }
    }
}
