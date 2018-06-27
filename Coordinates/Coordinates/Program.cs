using System;

namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which quandrant is located coordinates in?");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Give first coordinate (X): ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Give secons coordinate (Y): ");
            int y = int.Parse(Console.ReadLine());

            if ( x == 0 && y == 0 )
            {
                Console.WriteLine("Point ({0},{1} is located in the start of the coordinate system", x, y);
            } else if ( x > 0 && y > 0) {
                Console.WriteLine("Point ({0},{1}) is located in First quandrant.", x, y);
            } else if ( x > 0 && y < 0)
            {
                Console.WriteLine("Point ({0},{1}) is located in Second quandrant.", x, y);
            } else if ( x < 0 && y < 0)
            {
                Console.WriteLine("Point ({0},{1}) is located in Third quandrant.", x, y);
            } else if ( x < 0 && y > 0)
            {
                Console.WriteLine("Point ({0},{1}) is located in Fourth quandrant.", x, y);
            }

            Console.ReadKey();
        }
    }
}
