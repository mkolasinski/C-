using System;

namespace Positive_or_negative_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Compare two integers!");
            Console.WriteLine("Enter your number:");
            num = int.Parse(Console.ReadLine());

            if ( num < 0 )
            {
                Console.WriteLine("Your number is negative!");
                Console.ReadKey();
            } else if ( num > 0)
            {
                Console.WriteLine("Your number is positive :)");
                Console.ReadKey();
            }
            else if ( num == 0 )
            {
                Console.WriteLine("Your number is 0.");
                Console.ReadKey();
            }
        }
    }
}
