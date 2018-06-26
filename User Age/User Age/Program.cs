using System;

namespace User_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You Look Younger than {0} ", age);
            Console.ReadLine();
        }
    }
}
