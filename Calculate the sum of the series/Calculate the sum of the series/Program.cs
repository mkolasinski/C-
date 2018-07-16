using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_the_sum_of_the_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int sum = 0;
            int t = 1;
            Console.Write("\n\n");
            Console.Write("Calculate the sum of the series 1 +11 + 111 + 1111 + .. n terms:\n");
            Console.Write("------------------------------------------------------------------");

            Console.WriteLine("Input the number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());

            for ( i = 1; i <= n; i++ )
            {
                Console.Write("{0} + ", t);
                sum = sum + t;
                t = (10 * t) + 1;
            }
            Console.Write("The sum is: {0} ", sum);
            Console.ReadKey();
        }
    }
}
