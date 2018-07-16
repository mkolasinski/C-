using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_odd_numbers_from_1_to_99
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the odd numbers from 1 to 99");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            for ( int i = 1; i <= 99; i++ )
            {
                if ( i % 2 != 0 )
                {
                    Console.WriteLine(i);
                } 
            }
            Console.ReadKey();
        }
    }
}
