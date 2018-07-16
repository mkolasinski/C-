using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_user_define_function_with_parameters
{
    class Program
    {
        public static void Welcome(string name)
        {
            Console.WriteLine("Welcome my friend " + name + "!");
        }

        public static void NiceDay()
        {
            Console.WriteLine("Have a nice day!");
            Console.ReadKey();
        }

        public static void Main()
        {
            Console.WriteLine("Create an user define the function with some parameters: ");
            Console.WriteLine("----------------------------------------------------------------");

            string word;

            Console.WriteLine("Please input Your name: ");
            word = Console.ReadLine();
            Console.WriteLine("~~ ~~ ~~ ~~ ~~ ~~ ~~ ~~ ~~ ~~");
            Welcome(word);
            NiceDay();
            Console.WriteLine("~~ ~~ ~~ ~~ ~~ ~~ ~~ ~~ ~~ ~~");
        }
    }
}
