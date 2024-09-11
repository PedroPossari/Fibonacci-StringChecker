using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class StringChecker
    {
        public bool ContainsLetterA(string input)
        {
            return input.IndexOf('a', StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public int CountLetterA(string input)
        {
            int count = 0;
            foreach (char c in input.ToLower())
            {
                if (c == 'a')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
