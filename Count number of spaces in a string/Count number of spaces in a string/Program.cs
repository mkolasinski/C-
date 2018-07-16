using System;
public class Counter
{
    public static int Count(string str)
    {
        int counter = 0;
        string str1;

        for ( int i = 0; i<str.Length;i++)
        {
            str1 = str.Substring(i, 1);
            if ( str1 == " ")
            {
                counter++;
            }
        return counter;
        }
    }

    public static void Main()
    {
        string str2;
        Console.WriteLine("Function to count number of spaces in word");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Please input a string: ");
        str2 = Console.ReadLine();
        Console.WriteLine("\"" + str2 + "\" " + " contains {0} spaces", Count(str2) );
    }
}