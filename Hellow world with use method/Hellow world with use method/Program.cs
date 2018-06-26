using System;

namespace Hellow_world_with_use_method
{
    class Program
    {
        public static void hello()
        {
            Console.WriteLine("Welcome!");
            Console.ReadLine();
        }

        public static void HaveNice()
        {
            Console.WriteLine("Have a Nice Day!");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            hello();
            HaveNice();
        }
    }
}
