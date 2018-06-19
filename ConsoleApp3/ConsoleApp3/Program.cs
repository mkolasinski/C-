using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Program pomoże obliczyć Ci pole lub obwód koła.");
            Console.Write("Podaj r: ");
            double r = double.Parse(Console.ReadLine());
            const double pi = Math.PI;
            double obwod = Math.Round((2 * pi * r), 2);
            double pole = Math.Round((2 * pi * Math.Sqrt(r)), 2);
            Console.WriteLine("Obwód koła wynosi: " + obwod);
            Console.WriteLine("Pole koła wynosi: " + pole);
            Console.ReadLine();
        }
    }
}
