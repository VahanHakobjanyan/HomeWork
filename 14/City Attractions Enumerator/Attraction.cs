using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City_Attractions_Enumerator
{
    internal class Attraction
    {
        public string Name { get; }
        public string Description { get; }
        public string Category { get; }

        public Attraction(string name, string description, string category)
        {
            Name = name;
            Description = description;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name} is {Category}\n{Description}\n";
        }
    }
}
