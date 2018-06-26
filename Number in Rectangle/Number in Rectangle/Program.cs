using System;

namespace Number_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            Console.ReadLine();
            Console.WriteLine("{0}{0}{0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0}{0}{0}", a);
            Console.ReadLine();
        }
    }
}
