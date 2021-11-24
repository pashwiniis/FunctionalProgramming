using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Math;
namespace FunctionalProgramming
{
    public class FlipCoin
    {
        public int headCount = 0;
        public int tailCount = 0;
        public double headCountPercent = 0;
        public double tailCountPercent = 0;

        public void  Calculatepercentage()
        {
            
           

            Console.WriteLine("Enter the number of times to Filp a Coin");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i= 0; i < num; i++)
            {
                
                 double check = random.NextDouble();

                
                if (check < 0.5)
                {
                    Console.WriteLine("Coin side is tail");
                    tailCount = tailCount + 1;
                }
                else
                {
                    Console.WriteLine("Coin side is head");
                    headCount = headCount + 1;  
                }
               
            }
            
            headCountPercent = headCount * 100 /num; 

           tailCountPercent = tailCount * 100 / num;
            Console.WriteLine(" HeadCountPercent is "  + headCountPercent);
           Console.WriteLine(" TailCountPercent is " + tailCountPercent);
        }
    }
}
