using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_characters_of_the_string_in_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string empty = "";
            string word;
            int l = 0;
            Console.WriteLine("Reverse order for word");
            Console.WriteLine("-------------------------");
            Console.WriteLine(empty);

            Console.WriteLine("Input the string: ");
            word = Console.ReadLine();

            l = word.Length - 1;
            Console.WriteLine(empty);
            Console.WriteLine("The characters of the string in reverse are: ");
            Console.WriteLine(empty);

            while (l >= 0)
            {
                Console.WriteLine("{0} ", word[l]);
                l--;
            }
            Console.ReadKey();
        }
    }
}
