using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_the_specified_day_of_the_week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("Today is: {0}", today);

            TimeSpan duration = new TimeSpan(40, 0, 0, 0);

            DateTime answer = today.Add(duration);

            Console.WriteLine("Name of the day: {0:dddd}", answer);

            Console.ReadKey();
        }
    }
}
