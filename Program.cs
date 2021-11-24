using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Math;
namespace FunctionalProgramming
{
    class FlipCoinPercentage
    { 
            
        public static void Main(string[] args)
        {
            Console.WriteLine("1.FlipaCoin\n2.CheckLeapYear\n3.CommandlineArgument\n4.HarmonicNumber\n5.Primefactors\n6.QuotientAndRemainder\n7.SwapTwoNumbers\n8.EvenOdd\n9.CheckAplphabetAndVowels\n10.LargerNumber\n11.ReplaceString");
            int ch;
            Console.WriteLine("Enter your choice");
            ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                      FlipCoin f = new FlipCoin();
                      f.Calculatepercentage();
                      break;

                case 2:
                     CheckLeapYear l = new CheckLeapYear();
                      l.Leapyear();
                      break;

               case 3:
                    int n = 0;
                    foreach (string obj in args)
                    {
                        n = int.Parse(obj);
                        Console.WriteLine(n);

                    }
                    CommandLineArg command = new CommandLineArg();
                    command.PowerOfTwo(n);
                    break;

               case 4:
                    HarmonicNumber h = new HarmonicNumber();
                    double num = h.NthHarmonic(8);
                    Console.WriteLine("The Nth harmonic number is  " +num);
                    break;

                case 5:
                    PrimeFactor primeFactor = new PrimeFactor();
                    primeFactor.Factorization();
                    break;

                case 6:
                    QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                    quotientAndRemainder.FindQandR();
                    break;

                case 7:
                    SwapTwoNumbers s = new SwapTwoNumbers();
                    s.Swapping();
                    break;

                case 8:

                    EvenAndOdd e = new EvenAndOdd();
                    e.CheckEvenOdd();
                    break;

                case 9:
                    Alphabet a = new Alphabet();
                    a.CheckVowels(args);
                    break;

                case 10:
                    LargestNumber num1 = new LargestNumber();
                    num1.FindThreeLargest();
                    break;

                case 11:
                    Username u = new Username();
                    u.inputUsername();
                    break;
                default:
                    Console.WriteLine("Incorrect choice");
                    break;
            }




















            



            

             

             

            

             
           

            

            

           

               
        }
    }
}