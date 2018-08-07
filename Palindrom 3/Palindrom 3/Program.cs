using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_3
{
    class Program
    {
        public static void Reverse()
        {
            string inputStr, reverseStr;

            Console.WriteLine("Input your string:");
            inputStr = Console.ReadLine();
            reverseStr = new string(inputStr.Reverse().ToArray());

            if (inputStr == reverseStr)
            {
                Console.WriteLine("Your string is a palindrom.");
            }
            else 
            {
                Console.WriteLine("Try Again. It is not a palindrom.");
                Console.WriteLine("");
                Reverse();
            }
        }

        static void Main()
        {
            Console.WriteLine("Check if your string is a palindrom");
            Console.WriteLine("--------------------------------------");

            Reverse();

            Console.ReadKey();
        }
    }
}
