using System;

namespace Remove_char_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("MicrosoftVisualStudio", 4));
            Console.WriteLine(remove_char("MicrosoftVisualStudio", 11));
            Console.WriteLine(remove_char("MicrosoftVisualStudio", 18));
            Console.ReadLine();
        }
        public static string remove_char(string str, int i)
        {
            return str.Remove(i, 1);
        }
    }
}
