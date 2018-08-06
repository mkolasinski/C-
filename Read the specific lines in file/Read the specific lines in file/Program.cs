using System;
using System.IO;
using System.Text;

namespace Read_the_specific_lines_in_file
{
    class Program
    {
        static void Main()
        {
            string fileName = @"mytest.txt";
            string[] Arrlines;
            int n, a;

            Console.WriteLine("Read the specific lines in file");
            Console.WriteLine("xxx---xxx---xxx---xxx---xxx---xxx---xxx---xxx");
            Console.WriteLine("");

            if ( File.Exists(fileName) )
            {
                File.Delete(fileName);
            }

            Console.WriteLine("Input number of lines to write in file");
            a = int.Parse(Console.ReadLine());

            Arrlines = new string[a];
            Console.WriteLine("Input  {0} strings below: ", a);

            for ( int i = 0; i < a; i++ )
            {
                Console.WriteLine("Input line {0}: ", i + 1);
                Arrlines[i] = Console.ReadLine();
            }

            System.IO.File.WriteAllLines(fileName, Arrlines);

            Console.WriteLine("Input which line you want to display: ");
            int l = int.Parse(Console.ReadLine());

            if (l >= 1 && l <= a)
            {
                Console.WriteLine("The content of the line {0} of the file {1} is: ", l, fileName);

                if ( File.Exists(fileName) )
                {
                    string[] lines = File.ReadAllLines(fileName);
                    Console.WriteLine("{0} ", lines[l-1]);
                }
            }
            else
            {
                Console.WriteLine("Please input the correct line no.");
            }
            Console.WriteLine();
        }
    }
}
