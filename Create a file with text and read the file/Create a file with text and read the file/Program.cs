using System;
using System.IO;
using System.Text;

namespace Create_a_file_with_text_and_read_the_file
{
    class Program
    {
        static void Main()
        {
            string file = @"mytest.txt";

            try
            {
                if ( File.Exists(file) )
                {
                    File.Delete(file);
                }
                Console.WriteLine("The program creates a file with test and read the file");
                Console.WriteLine("----------------------------------------------------------");

                using (StreamWriter str = File.CreateText(file))
                {
                    str.WriteLine("Hello! ");
                    str.WriteLine("This is the content of this file...");
                }

                using (StreamReader streamReader = File.OpenText(file))
                {
                    string s = " ";
                    Console.WriteLine("Here is the content of my file {0}", file);
                    while ((s = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine(" ");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
            Console.ReadKey();
        }
    }
}
