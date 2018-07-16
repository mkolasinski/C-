using System;

namespace Pyramid_with_numbers
{
    class Program
    {
        public static void Main()
        {
            int row, spc, k, i, j;
            Console.WriteLine("Display the pattern like pyramid with repeating a numbers with in same row.");
            Console.WriteLine("");

            Console.WriteLine("Input a number of rows: ");
            row = int.Parse(Console.ReadLine());

            spc = row + 4 - 1;

            for ( i = 1; i <= row; i++)
            {
                for ( k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for ( j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", i);
                }
                Console.Write("\n");
                spc--;
            }
            Console.ReadKey();
        }
    }
}
