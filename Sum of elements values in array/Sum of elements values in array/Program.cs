using System;

namespace Sum_of_elements_values_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            Console.WriteLine("Array: [{0}]", string.Join(",", numbers));

            int sum = 0;
                for ( int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();
        }
    }
}
