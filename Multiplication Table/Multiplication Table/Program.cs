using System;

namespace Multiplication_Table
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            int a;
            int result;

            Console.WriteLine("Enter a basic number");
            a = int.Parse(Console.ReadLine());

            result = a * 1;
            Console.WriteLine("The table is : {0} x {1} = {2}", a, 1,result);
            result = a * 2;
            Console.WriteLine("             : {0} x {1} = {2}", a, 2, result);
            result = a * 3;
            Console.WriteLine("             : {0} x {1} = {2}", a, 3, result);
            result = a * 4;
            Console.WriteLine("             : {0} x {1} = {2}", a, 4, result);
            result = a * 5;
            Console.WriteLine("             : {0} x {1} = {2}", a, 5, result);
            result = a * 6;
            Console.WriteLine("             : {0} x {1} = {2}", a, 6, result);
            result = a * 7;
            Console.WriteLine("             : {0} x {1} = {2}", a, 7, result);
            result = a * 8;
            Console.WriteLine("             : {0} x {1} = {2}", a, 8, result);
            result = a * 9;
            Console.WriteLine("             : {0} x {1} = {2}", a, 9, result);
            result = a * 10;
            Console.WriteLine("             : {0} x {1} = {2}", a, 10, result);
            Console.ReadLine();
        }
    }
}
