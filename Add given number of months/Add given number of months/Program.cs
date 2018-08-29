using System;

namespace Add_given_number_of_months
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2018, 8, 29);
            int x;
            int y = 100;

            for (x = 0; x <= y; x++)
            {
                Console.WriteLine(date.AddMonths(x).ToString("d"));
            }

            Console.ReadKey();
            
        }
    }
}
