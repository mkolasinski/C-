using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString, reverseString;

            Console.WriteLine("Check if your word is a palindrom");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Input your word:");
            inputString = Console.ReadLine();
            reverseString = new string(inputString.Reverse().ToArray());
            
            if ( inputString == reverseString )
            {
                Console.WriteLine("Your word is a PALINDROM!");
                Console.WriteLine(reverseString);
            } else
            {
                Console.WriteLine("Try Again! Your word is not a palindrom...");
            }
            Console.ReadKey();
        }
    }
}
