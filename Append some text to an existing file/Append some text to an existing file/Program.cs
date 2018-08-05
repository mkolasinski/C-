using System;
using System.IO;
using System.Text;

namespace Append_some_text_to_an_existing_file
{
    class Program
    {
        static void Main()
        {
            string fileName = @"test.txt";

            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                Console.WriteLine("Append some text to an existing file");
                Console.WriteLine(" ");

                //Create a file

                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine("Hello!");
                    fileStr.WriteLine("How was your day?");
                }

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine("Here is the content of your file: ");

                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"mytest.txt", true))
                {
                    file.WriteLine(" This is the line append at last line.");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine("Here is the content of the file after appending the text: ");
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
            Console.ReadKey();
            }
        }
    }
