using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class CommandLineArg
    {
        
        public int p;
        public void PowerOfTwo(int N)
        {
            
            for (int i = 0; i <= N; i++)
            {
                if(i==0)
                {
                    p = 1;
                }
                else
                {
                    p = p * 2;
                }
                Console.WriteLine("the power of 2^" +i +" = " +p);
            }
            
                Console.ReadKey();
        }
    }
}
