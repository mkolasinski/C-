using System;

namespace Units_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit, output;
            double n, result;

            Console.WriteLine("Welcome to UNITS CALCULATOR!");
            Console.WriteLine("--------");
            Console.ReadLine();

            Console.WriteLine("Select unit, click convenient letter: ");
            Console.WriteLine("m - meters");
            Console.WriteLine("km - kilometers");
            Console.WriteLine("mm - milimeters");
            unit = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an output unit:");
            output = Convert.ToString(Console.ReadLine());
            
            if ( unit == "m")
            {
                if ( output == "mm")
                {
                    result = n * 1000;
                    Console.WriteLine(result + "mm");
                    Console.ReadLine();
                }
                else if ( output == "km")
                {
                    result = n/1000;
                    Console.WriteLine(result + "km");
                    Console.ReadLine();
                }
            } else if ( unit == "mm")
                {
                    if (output == "m")
                    {
                        result = n / 100;
                        Console.WriteLine(result + "m");
                        Console.ReadLine();
                    } else if ( output == "km")
                        {
                            result = n / 1000000;
                            Console.WriteLine(result + "km");
                            Console.ReadLine();
                        }
            } else if ( unit == "km")
                {
                    if (output == "m")
                    {
                        result = n * 1000;
                        Console.WriteLine(result + "m");
                        Console.ReadLine();
                    } else if (output == "mm")
                        {
                            result = n * 1000000;
                            Console.WriteLine(result + "mm");
                            Console.ReadLine();
                        }
                }
            }
        } 
    }
