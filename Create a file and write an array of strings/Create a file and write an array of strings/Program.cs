using System;
using System.IO;
using System.Text;

namespace Create_a_file_and_write_an_array_of_strings
{
    class Program
    {
        static void Main()
        {
            string fileName = @"mytest.txt";
            string[] Array;

            Console.WriteLine("Create a file and write an array of strings");
            Console.WriteLine("----------------------------------------------");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.WriteLine(" ");
            Console.WriteLine(" Input a number of lines to write in file: ");

            int n = int.Parse(Console.ReadLine());

            Array = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Line {0}:", i + 1);
                Array[i] = Console.ReadLine();
            }

            System.IO.File.WriteAllLines(fileName, Array);

            using (StreamReader str = File.OpenText(fileName))
            {
                string s = " ";
                Console.WriteLine("The content of Your file is: ");
                Console.WriteLine("");

                while (( s = str.ReadLine() ) != null )
                {
                    Console.WriteLine(" {0} ", s);
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
