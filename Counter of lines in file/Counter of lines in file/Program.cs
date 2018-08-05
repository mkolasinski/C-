using System;
using System.IO;
using System.Text;

namespace Counter_of_lines_in_file
{
    class Program
    {
        static void Main()
        {
            string fileName = @"mytest.txt";
            int count;

            try
            {
                if ( File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                Console.WriteLine("Conter of lines in file.");
                Console.WriteLine("");

                //Create the file

                using ( StreamWriter str = File.CreateText(fileName))
                {
                    str.WriteLine("This is first line.");
                    str.WriteLine("This is second line.");
                    str.WriteLine("This is third line.");
                    str.WriteLine("This is fourth line.");
                    str.WriteLine("This is fifth line.");
                }

                using ( StreamReader openFile = File.OpenText(fileName))
                {
                    string s = "";

                    count = 0;

                    Console.WriteLine("The sum of lines in the file");

                    while ( ( s = openFile.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        count++;
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("The number of lines in file {0} is: {1}", fileName, count);
            }

            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }

            Console.ReadKey();
        }
    }
}
