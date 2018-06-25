using System;

namespace Swapping_Two_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the First Number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number: ");
            int b = int.Parse(Console.ReadLine());

            int swap = a;
            a = b;
            b = swap;
            Console.WriteLine("------");
            Console.WriteLine("After Swapping is: ");
            Console.WriteLine("Number one is: " + a);
            Console.WriteLine("Number two is: " + b);
            Console.ReadLine();
        }
    }
}
