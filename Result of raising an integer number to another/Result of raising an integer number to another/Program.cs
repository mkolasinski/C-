using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_of_raising_an_integer_number_to_another
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, total;
            Console.WriteLine("Calculate the result of raising an integer number to another: ");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Input a Base: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input an Exponent: ");
            b = Convert.ToInt32(Console.ReadLine());

            total = Math.Pow(a, b);
            Console.WriteLine("Total: {0} ", total);
            Console.ReadKey();
        }
    }
}
