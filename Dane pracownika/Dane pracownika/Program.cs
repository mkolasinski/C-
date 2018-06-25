using System;

namespace Dane_pracownika
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik osoba = new Pracownik();
            osoba.Imie = "Michał";
            osoba.Nazwisko = "Kolasiński";
            osoba.Wiek = 27;
            osoba.Pensja = 4000;
            Console.WriteLine("Imię pracownika: " + osoba.Imie);
            Console.WriteLine("Nazwisko pracownika: " + osoba.Nazwisko);
            Console.WriteLine("Wiek pracownika: " + osoba.Wiek);
            Console.WriteLine("Pensja: " + osoba.Pensja);
            Console.WriteLine("--------------");
            Console.ReadLine();
        }
    }
}
