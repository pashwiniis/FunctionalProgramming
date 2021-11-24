using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class HarmonicNumber
    {
        // Function to find N-th Harmonic Number
        public  double NthHarmonic(int N)
        {
            // H1 = 1
            float harmonic = 1;

            // loop to apply the forumula
            // Hn = H1 + H2 + H3 ... +
            // Hn-1 + Hn-1 + 1/n
            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }
            return harmonic;
          
        }

          
       
    }

}

