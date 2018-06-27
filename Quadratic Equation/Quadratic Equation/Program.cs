using System;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            double delta, x1, x2;

            Console.WriteLine("QUADRATIC EQUATION:");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = Convert.ToInt32(Console.ReadLine());

            delta = b * b - (4 * a * c);

            if ( delta == 0 )
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Only one root: {0}", x1);
                Console.ReadKey();
            } else if ( delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta))/2*a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Roots: {0}, {1}", x1, x2);
                Console.ReadKey();
            } else {
                Console.WriteLine("This equation has not any root.");
                Console.ReadKey();
            }
        }
    }
}
