using System;

namespace Leap_year_or_not
{
    class Program
    {
        static void Main()
        {
            int year;
            Console.WriteLine("Enter an year");
            Console.WriteLine("-------------------------------");

            Console.Read();
            year = int.Parse(Console.ReadLine());

            if ( (year % 4) == 0 ) {
                Console.WriteLine("The year" + year + " is a leap");
            } else if ( (year % 400) == 0 )
            {
                Console.WriteLine("The year" + year + " is a leap");
            } else if ( (year % 100) == 0 )
            {
                Console.WriteLine("The year" + year + " is not a leap");
            } else
            {
                Console.WriteLine("The year" + year + " is a not a leap");
            }

            Console.ReadKey();
        }
    }
}
