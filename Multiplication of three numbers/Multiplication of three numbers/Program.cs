using System;

namespace Multiplication_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number: ");
            int c = int.Parse(Console.ReadLine());

            int result = a * b * c;
            Console.WriteLine();
            Console.WriteLine("Result is: " + result);
            Console.ReadKey();
        }
    }
}
