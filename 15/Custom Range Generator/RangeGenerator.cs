using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Range_Generator
{
    internal class RangeGenerator
    {
        private int _rangeStart;
        private int _rangeEnd;

        public RangeGenerator(int rangeStart, int rangeEnd)
        {
            _rangeStart = rangeStart;
            _rangeEnd = rangeEnd;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = _rangeStart; i <= _rangeEnd; i++)
            {
                yield return i;
            }
        }
    }
}
