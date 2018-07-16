using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separate_the_individual_characters
{
    class Program
    {
        static void Main()
        {
            string word;
            int length = 0;

            Console.WriteLine("Separate an individual characters from a string");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Input the word: ");

            word = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("The characters of the string are: ");
            Console.WriteLine("");

            while ( length <= word.Length - 1)
            {
                Console.WriteLine("{0} ", word[length]);
                length++;
            }

            Console.Write("\n\n");
            Console.ReadKey();
        }
    }
}
