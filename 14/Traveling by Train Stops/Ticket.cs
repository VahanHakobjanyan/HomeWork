using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_by_Train_Stops
{
    internal class Ticket : IEnumerable, IEnumerator
    {
        List<Stop> _stops;
        int _index = -1;
        public Ticket()
        {
            _stops = new List<Stop>();
        }

        public void AddStopsToTicket(Stop stop)
        {
            if (_stops.Contains(stop))
            {
                Console.WriteLine("Already added");
            }
            else
            {
                _stops.Add(stop);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_index == _stops.Count - 1)
            {
                Reset();
                return false;
            }
            _index++;
            return true;
        }
        public object Current
        {
            get { return _stops[_index]; }
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
