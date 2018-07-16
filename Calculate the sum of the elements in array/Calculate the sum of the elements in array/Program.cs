using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_the_sum_of_the_elements_in_array
{
    class Program
    {
        public static int Sum(int[] array)
        {
            int total = 0;
            for ( int i =0; i<array.Length; i++ )
            {
                total += array[i];
            }
            return total;
        }

        public static void Main()
        {
            int[] array = new int[6];
            Console.WriteLine("Function calculates the sum of elements in array: ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Input 6 elements in the array: ");

            for (int j = 0; j < 6; j++)
            {
                Console.Write("element - {0} : ", j);
                array[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of the elements of the array is {0}: ", Sum(array));
            Console.ReadKey();
        }
    }
}
