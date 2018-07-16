using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charackter_of_letter_in_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Check the character of letter");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Input Your Custom Letter");
            a = (char)Console.Read();

            if ( Char.IsLetter(a) )
            {
                if ( Char.IsUpper(a) )
                {
                    Console.WriteLine("The character is uppercase.");
                } else
                {
                    Console.WriteLine("The character is lowercase.");
                }
            } else
            {
                Console.WriteLine("The character is the other than alphabetic. Try again.");
            }
            Console.ReadKey();
        }
    }
}
