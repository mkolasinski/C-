using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string action;
            double bmi, m, kg;

            Console.WriteLine("OBLICZ SWóJ WSKAŹNIK BMI: ");
            Console.WriteLine("Podaj swoją płeć (k) lub (m): ");
            action = Console.ReadLine();
            
            if ( action == "k" || action == "m")
            {
                Console.WriteLine("Podaj swój wzrost w m: ");
                    m = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj swoją wagę w kg: ");
                    kg = double.Parse(Console.ReadLine());
                    bmi = Math.Round(kg/(m*m));
                Console.WriteLine("Wskaźnik BMI wynosi: " + bmi);
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Podałeś złą płeć. Uruchom program jeszcze raz i dokonaj obliczeń.");
                Console.ReadLine();
            }
        }
    }
}
