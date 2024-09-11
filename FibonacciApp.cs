using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class FibonacciApp
    {   
        public class FibonacciSequence
        {
            public List<int> GenerateFibonacci(int limit)
            {
                List<int> sequence = new List<int> { 0, 1 };

                while (true)
                {
                    int nextValue = sequence[sequence.Count - 1] + sequence[sequence.Count - 2];

                    if (nextValue > limit)
                        break;

                    sequence.Add(nextValue);
                }

                return sequence;
            }

            public bool IsNumberInFibonacci(int number, List<int> sequence)
            {
                return sequence.Contains(number);
            }
        }
    }
}
