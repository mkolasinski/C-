using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute_sum_of__elements_of_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 1, 2, 3, 4, 5, 6, 8, 9, 0 };
            Console.WriteLine("Array: [{0}]", string.Join(", ", numbers));

            int total = 0;

            for ( int i = 0; i < numbers.Length; i++ )
            {
                total += numbers[i];
            }
            Console.WriteLine("Sum: " + total);
            Console.ReadKey();
        }
    }
}
