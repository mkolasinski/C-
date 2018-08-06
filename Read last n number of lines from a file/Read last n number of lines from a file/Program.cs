using System;
using System.IO;
using System.Text;

namespace Read_last_n_number_of_lines_from_a_file
{
    class Program
    {
        static void Main()
        {
            string fileName = @"mytest.txt";
            string[] Arrlines;

            Console.WriteLine("READ LAST n NUMBER OF LINES FROM A FILE");
            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("");
            
            if ( File.Exists(fileName) )
            {
                File.Delete(fileName);
            }

            Console.WriteLine("Input a number of lines: ");
            int n = int.Parse(Console.ReadLine());

            Arrlines = new string[n];

            Console.WriteLine("Input {0} strings below: ", n);

            for ( int i = 0; i < n; i++ )
            {
                Console.Write("Input line {0}: ", i + 1);
                Arrlines[i] = Console.ReadLine();
            }

            System.IO.File.WriteAllLines(fileName, Arrlines);

            Console.WriteLine("Input how many lines you want to display?: ");
            int lines = int.Parse(Console.ReadLine());
            int m = lines;

            if (lines > 1 && lines <= n)
            {
                Console.WriteLine("The content of the last {0} lines of the file {1} is: ", lines, fileName);

                if ( File.Exists(fileName))
                {
                    for (int i = n - lines; i < n; i++)
                    {
                        string[] alllines = File.ReadAllLines(fileName);
                        Console.WriteLine("The last no {0} line is: {1}", m, alllines[i]);
                        m--;
                    }
                }
                else
                {
                    Console.WriteLine("Please input the correct line no.");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
