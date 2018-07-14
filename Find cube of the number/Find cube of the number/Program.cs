using System;

namespace Find_cube_of_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i;
            Console.WriteLine("Input number");
            a = Convert.ToInt32(Console.ReadLine());

            for ( i = 1; i <= a; i++)
            {
                Console.WriteLine("Number is: {0} and cube of the {1} is: {2} \n", i,i, (i * i * i));
            }
            Console.ReadKey();
        }
    }
}
