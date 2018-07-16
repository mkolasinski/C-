using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_the_position_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, substr;
            int position;

            Console.WriteLine("To find and index in string");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Input a string: ");

            str = Console.ReadLine();

            Console.WriteLine("Input a substring to be found in the string: ");

            substr = Console.ReadLine();

            position = str.IndexOf(substr);

            if ( position < 0 )
            {
                Console.WriteLine("The substring no found in the given string! Let's try again.");
            } else
            {
                Console.WriteLine("Found '{0}' in '{1}' at position {2}", str, substr, position);
            }

            Console.ReadKey();
        }
    }
}
