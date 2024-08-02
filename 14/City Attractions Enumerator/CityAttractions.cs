using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City_Attractions_Enumerator
{
    internal class CityAttractions : IEnumerable, IEnumerator
    {
        List<Attraction> Attractions;
        int _index = -1;

        public CityAttractions()
        {
            Attractions = new List<Attraction>();
        }

        public void AddAttraction(Attraction attraction)
        {
            if (Attractions.Contains(attraction))
            {
                Console.WriteLine($"{attraction.Name} is already on your list");
            }
            else
            {
                Attractions.Add(attraction);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_index == Attractions.Count - 1)
            {
                Reset();
                return false;
            }
            _index++;
            return true;
        }

        public object Current
        {
            get { return Attractions[_index]; }
        }
        public void Reset()
        {
            _index = -1;
        }
    }
}
