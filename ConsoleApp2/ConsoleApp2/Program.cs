using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę, dla której chcesz obliczyć moduł:");
            int a = int.Parse(Console.ReadLine());
            int b;
            b = (a < 0 ? -a : a);
            Console.Write("Moduł Twojej liczby wynosi: " + b);
            Console.ReadKey();
        }
    }
}
