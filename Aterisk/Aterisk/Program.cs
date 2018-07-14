using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aterisk
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            Console.Write("\n\n");
            Console.Write("Display the pattern like right angle using asterisk:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
