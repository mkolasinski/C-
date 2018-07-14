using System;

namespace Day_number_and_display_its_equivalent_day_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Accept day number and display its equivalent day name in the word: ");
            Console.WriteLine("Input day No.");

            int dayNo = int.Parse(Console.ReadLine());

            switch (dayNo)
            {
                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;
                default:
                    Console.WriteLine("Let's try again and input correct number");
                    break;
            }
            Console.ReadKey();
        }
    }
}
