using System;

namespace Check_two_integers__are_equal_or_not_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program can to compare You two integers.");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.ReadLine();

            if ( a == b )
            {
                Console.WriteLine("These numbers: {0} and {1} are equal", a, b);
                Console.ReadLine();
            } else
            {
                Console.WriteLine("These numbers are not equal");
                Console.ReadKey();
            }
        }
    }
}
