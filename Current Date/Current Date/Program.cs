using System;

namespace Current_Date
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.Write("Now is: " + today);
            Console.ReadKey();
        }
    }
}
