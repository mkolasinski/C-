using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_corresponding_elements_in_two_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { -4, 5, 6, 7 };
            int[] secondArray = { -2, 1, 0, 9 };

            Console.WriteLine("Array no. 1: [{0}]", string.Join(", ", firstArray));
            Console.WriteLine("Array no. 2: [{0}]", string.Join(", ", secondArray));

            Console.WriteLine("Multiply corresponding elements of two arrays: ");

            for ( int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine(firstArray[i] * secondArray[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
