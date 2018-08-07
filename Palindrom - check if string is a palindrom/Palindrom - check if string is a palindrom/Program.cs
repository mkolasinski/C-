using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom___check_if_string_is_a_palindrom
{
    class Program
    {
        static void Main()
        {
            string inputString = "one two three";
            string resultString = string.Join(" ", inputString.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine(resultString);
            Console.ReadKey();
        }
    }
}
