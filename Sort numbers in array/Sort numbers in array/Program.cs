using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_numbers_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7] { 1, 14, 22, 89, 90, 2, 3 };
            int temp = 0, i, j;

            for ( i = 0; i < array.Length; i++)
            {
                for ( j = 0; j < array.Length; j++)
                {
                    if ( array[i] < array[j] )
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted numbers: ");
            for ( i = 0; i < array.Length; i++ )
            {
                Console.WriteLine("{0}", array[i]);
            }
            Console.ReadKey();
        }
    }
}
