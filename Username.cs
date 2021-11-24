using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Username
    {
        public void inputUsername()
        {
            string str1= "Hello <<username>>,How are you";
            Console.WriteLine("The first source string is =  " +str1);
            Console.WriteLine("Enter username of string");
            string username=Console.ReadLine();

                if(username.Length >= 3)
            {
                Console.WriteLine("Hello " + username +", How are you");
            }
                else
            {
                Console.WriteLine("Please enter the string more than 3 char");
            }

             
        
        }
    }
}
