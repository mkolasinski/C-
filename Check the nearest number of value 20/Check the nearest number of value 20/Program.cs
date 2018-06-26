using System;

namespace Check_the_nearest_number_of_value_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int value = 20;

            int value1 = Math.Abs(a - value);
            int value2 = Math.Abs(b - value);
            Console.WriteLine(
                value1 == value2 ? 0 : ( value1 < value2 ? a : b));
            Console.ReadLine();
        }
    }
}
