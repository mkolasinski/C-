using System;
using System.IO;
using System.Text;

namespace Create_file_with_text_and_read_the_file
{
    class Program
    {
        static void Main()
        {
            string fileName = @"mytext.txt";
            try
            {
                //Delete file
                if ( File.Exists(fileName) )
                {
                    File.Delete(fileName);
                }
                Console.WriteLine("Create a new file with content.");
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");

                //Create a file
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine("Hello my friend!");
                    fileStr.WriteLine("This is the first context of this file.");
                }

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine("This is the context of {0}", fileName);

                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
}
