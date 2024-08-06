using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generate_the_Fibonacci_sequence
{
    internal class FibonacciSequence
    {
        private int _sequenceEnd;

        public FibonacciSequence(int sequenceEnd)
        {
            _sequenceEnd = sequenceEnd;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int currentNumber = 1;
            int previousNumber = 0;
            int tempNumber = 0;

            if (_sequenceEnd == 1)
            {
                yield return 0;
            }
            else if (_sequenceEnd == 2)
            {
                yield return 1;
            }
            else
            {
                yield return 0;
                yield return 1;

                while (currentNumber + previousNumber <= _sequenceEnd)
                {
                    tempNumber = currentNumber;
                    currentNumber = currentNumber + previousNumber;
                    previousNumber = tempNumber;

                    yield return currentNumber;
                }
            }
        }
    }
}
