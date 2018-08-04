using System.IO;
using System;
using System.Text;

namespace Create_a_file
{
    class Program
    {
        static void Main()
        {
            string fileName = @"mytext.txt";
            try
            {
                Console.WriteLine("Create a file on your disk.");
                Console.WriteLine("------------------------------------");

                //Create a file.

                using (FileStream fileStr = File.Create(fileName));
                {
                    Console.WriteLine("A file was created.");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine("MyExcep.ToString()");
            }
        }
    }
}
