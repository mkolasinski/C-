using System;

namespace Sum_of_two_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOf(2, 5));
            Console.WriteLine(SumOf(7, 7));
            Console.WriteLine(SumOf(2, 13));
            Console.ReadLine();
        }
        public static int SumOf(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
