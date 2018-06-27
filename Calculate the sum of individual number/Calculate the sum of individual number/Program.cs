using System;

namespace Calculate_the_sum_of_individual_number
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an individual number to calculate its sum: ");
            int x = int.Parse(Console.ReadLine());

            string y = Convert.ToString(x);
            int sum = 0;
            for (int i = 0; i < y.Length; i++)
            {
                sum += Convert.ToInt32(y.Substring(i, 1));
            }

            Console.WriteLine("The sum is equal: " + sum);
            Console.ReadKey();
        }
    }
}
