using System;

namespace Kelvin_or_Fahrenheit_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Celsius Degrees: ");
            int degrees = int.Parse(Console.ReadLine());
            int kelvin = degrees + 273;
            int fahrenheit = degrees * 18 / 10 + 32;

            Console.WriteLine("Kelvin's Degrees = " + kelvin);
            Console.WriteLine("Fahrenheit's Degrees = " + fahrenheit);
            Console.ReadLine();
        }
    }
}
