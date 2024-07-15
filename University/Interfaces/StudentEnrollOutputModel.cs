using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Interfaces
{
    internal class StudentEnrollOutputModel
    {
        bool IsEnrolled;
        public StudentEnrollOutputModel(bool isEnrolled)
        {
            IsEnrolled = isEnrolled;
        }
    }
}
