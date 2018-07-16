using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_length_of_a_string
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word;
            int length = 0;
            Console.WriteLine("Find the length of a string: ");
            Console.WriteLine("..................................");
            Console.WriteLine("Input a string: ");

            word = Console.ReadLine();

            for ( int i = 1; i <= word.Length; i++ )
            {
                length += 1;
            }

            Console.WriteLine("Length of your word is equal: " + length);
            Console.ReadKey();
        }
    }
}
