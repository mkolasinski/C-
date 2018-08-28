
#region Usings;

using System;
using System.Linq;

#endregion

namespace Basic_Structure_of_LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Data source
            int[] number_1 = new int[10] { 0, 1, 13, 14, 15, 25, 26, 29, 34, 37 };

            Console.WriteLine("Basic Structure of LINQ");
            Console.WriteLine("------------------------------");

            //Actions
            var nQuery = from VrNum in number_1 where (VrNum % 2) == 0 select VrNum;

            //Execution
            Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are :");

            foreach ( int VrNum in nQuery)
            {
                Console.Write("{0}, ", VrNum);
            }

            Console.Write("\n\n");

            Console.ReadLine();
        }
    }
}
