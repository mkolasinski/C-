using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_number_multiple_of_3_or_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer: ");
            int a = int.Parse(Console.ReadLine());

            if ( a > 0 )
            {
                Console.WriteLine(a % 3 == 0 || a % 7 == 0);
            }
            Console.ReadKey();
        }
    }
}
