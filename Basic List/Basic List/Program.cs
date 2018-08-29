using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            foreach ( int element in numbers)
            {
                Console.WriteLine("This is element of list: {0}", element);
            }

            Console.ReadKey();
        }
    }
}
