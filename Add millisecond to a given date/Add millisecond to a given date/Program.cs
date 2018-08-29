#region Usings;

using System;

#endregion

namespace Add_millisecond_to_a_given_date
{
    class Program
    {
        static void Main(string[] args)
        {
            string formatDate;

            formatDate = "MM/dd/yyyy hh:mm:ss.fffffff";

            DateTime dateOne = new DateTime(2018, 8, 29, 19, 0, 0);
            Console.WriteLine("Original date: {0} ({1:N0} ticks)", dateOne.ToString(formatDate), dateOne.Ticks);

            DateTime dateTwo = dateOne.AddMilliseconds(1);
            Console.WriteLine("Second date: {0} ({1:N0} ticks)", dateTwo.ToString(formatDate), dateTwo.Ticks);
            Console.WriteLine("Difference between dates: {0} ({1:N0})", dateTwo - dateOne, dateTwo.Ticks - dateOne.Ticks);

            DateTime dateThree = dateOne.AddMilliseconds(2.5);
            Console.WriteLine("Third date: {0} ({1:N0} ticks)", dateThree.ToString(formatDate), dateThree.Ticks);
            Console.WriteLine("Difference between dates: {0} ({1:N0})", dateThree - dateOne, dateThree.Ticks - dateOne.Ticks);

            Console.ReadKey();

        }
    }
}
