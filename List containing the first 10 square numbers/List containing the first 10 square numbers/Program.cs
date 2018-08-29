using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_containing_the_first_10_square_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            for ( i = 1; i <= 10; i++)
            {
                Console.WriteLine("Square: {0}",Math.Pow(i,2));
            }

            Console.ReadKey();
        }
    }
}
