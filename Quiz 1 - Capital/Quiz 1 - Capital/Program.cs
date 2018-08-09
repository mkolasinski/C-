using System;
using System.IO;
using System.Text;

namespace Quiz_1___Capital
{
    class Program
    {
        public static void Introduce()
        {
            string y;
            Console.WriteLine("QUIZ No. 1 - Capital");
            Console.WriteLine("------------------------");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("Press Y To Continue");

            y = Console.ReadLine();

            if (y == "y" || y == "Y")
            {
                Console.WriteLine("");
                Question1();
            }
            else
            {
                Console.WriteLine("Didn't press Y. Try Again.");
            }
        }
        public static void Question1()
        {
            Console.WriteLine("Which city is the capital of Spain?:");
            Console.WriteLine("");
            Console.WriteLine("A. Paris");
            Console.WriteLine("B. Barcelona");
            Console.WriteLine("C. Madrid");
            Console.WriteLine("");
            changeQuestion1();
        }

        public static void Question2()
        {
            Console.WriteLine("Which city is the capital of Sweden?:");
            Console.WriteLine("");
            Console.WriteLine("A. Oslo");
            Console.WriteLine("B. Helsinki");
            Console.WriteLine("C. Stockholm");
            Console.WriteLine("");
            changeQuestion2();
        }

        public static void changeQuestion1()
        {
            string ans;
            Console.WriteLine("Change Your Answer and Press a Letter:");
            Console.WriteLine("");
            ans = Console.ReadLine();

            if (ans == "b" || ans == "B")
            {
                Console.WriteLine("");
                Console.WriteLine("Correct!");
                Console.WriteLine("");
                Console.ReadKey();
                Question2();
            }
            else
            {
                Console.WriteLine("It's wrong! Try Again.");
                Console.WriteLine("");
                Console.ReadKey();
            }
        }

        public static void changeQuestion2()
        {
            string ans;
            Console.WriteLine("Change Your Answer and Press a Letter:");
            Console.WriteLine("");
            ans = Console.ReadLine();

            if (ans == "c" || ans == "")
            {
                Console.WriteLine("");
                Console.WriteLine("Correct!");
                Console.WriteLine("");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("It's wrong! Try Again.");
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
        public static void Main()
        {
            Introduce();
        }
    }
}
