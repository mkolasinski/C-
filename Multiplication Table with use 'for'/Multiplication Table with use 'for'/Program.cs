using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_with_use__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Display multiplication table");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Give a basic number: ");

            x = int.Parse(Console.ReadLine());

            for ( y = 1; y <= 10; y++)
            {
                Console.WriteLine("{0} x {1} = {2}", x, y, (x * y));
            }
            Console.ReadKey();
        }
    }
}
