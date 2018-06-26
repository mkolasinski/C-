using System;

namespace Odd_numbers_in_Array
{
    class Program
    {
        public static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            Console.WriteLine("Array: [{0}]", string.Join(",", nums));
            Console.WriteLine("Check if an array contains an odd number? " + even_odd(nums));
        }
        public static bool even_odd(int[] nums)
        {
            foreach (int num in nums)
            {
                if (num % 2 != 0)
                    return true;
            }
            return false;
        }
    }
}
