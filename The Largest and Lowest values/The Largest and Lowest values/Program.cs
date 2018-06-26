using System;

namespace The_Largest_and_Lowest_values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Input second integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Input third integer: ");
            int c = int.Parse(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Largest of three is: " + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Lowest of three is: " + Math.Min(a, Math.Min(b, c)));
            Console.ReadLine();
        }
    }
}
