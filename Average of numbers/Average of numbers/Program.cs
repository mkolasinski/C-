using System;

namespace Average_of_numbers
{
    class Program
    {
        static void Main()
        {
            double n1, n2, n3, n4, result;

            Console.Write("Enter First Number: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            n3 = double.Parse(Console.ReadLine());
            Console.Write("Enter Fourth Number: ");
            n4 = double.Parse(Console.ReadLine());

            result = (n1 + n2 + n3 + n4)/4;
            Console.ReadLine();
            Console.WriteLine("The average is: " + result);
            Console.ReadLine();
        }
    }
}
