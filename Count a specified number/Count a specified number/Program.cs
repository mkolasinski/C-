using System;
using System.Linq;

namespace Count_a_specified_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a Integer: ");
            int a = int.Parse(Console.ReadLine());

            int[] numbers = { 0, 1, 1, 2, 3, 4, 5, 6, 7, 7, 7, 8, 9, 9 };
            Console.WriteLine("Number of " + a + " present in the said array:");
            Console.WriteLine(numbers.Count(n => n == a));
            Console.ReadLine();
        }
    }
}
