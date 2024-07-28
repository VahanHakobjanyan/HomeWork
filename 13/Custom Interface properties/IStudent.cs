using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Interface_properties
{
    interface IStudent
    {
        string Name { get; set; }
        byte Age { get; set; }
        byte Grade { get; set; }
    }
}
