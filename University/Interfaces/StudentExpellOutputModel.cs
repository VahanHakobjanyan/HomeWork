using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Interfaces
{
    internal class StudentExpellOutputModel
    {
        Reason Reason { get; }

        public StudentExpellOutputModel(Reason reason)
        {
            Reason = reason;
        }
    }
}
