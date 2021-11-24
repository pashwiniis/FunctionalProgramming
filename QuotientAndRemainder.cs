using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class QuotientAndRemainder
    {
        public void FindQandR()
        {

            int dividend = 0;
           int divisor = 0;
            Console.WriteLine("enter the Dividend");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Divisor");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

           // Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
