using System;

namespace Sum_of_elements_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 8, 9, 12, 19, 24, 33 };
            Console.WriteLine("Array: [{0}]", string.Join(",", array));
            Console.ReadLine();

            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Sum of elements: " + sum);
            Console.ReadKey();
        }
    }
}
