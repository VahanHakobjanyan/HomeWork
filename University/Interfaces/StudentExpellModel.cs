using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Interfaces
{
    internal class StudentExpellModel
    {
        public Reason Reason { get; }
        public string Ssn { get; }

        public StudentExpellModel(Reason reason, string ssn)
        {
            Reason = reason;
            Ssn = ssn;
        }
    }
}
