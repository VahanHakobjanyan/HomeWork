﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Interface_properties
{
    internal class Student: IStudent
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public byte Grade { get; set; }
    }
}
