using System;

public class Program
{
    public static void Main(string[] args)
    {
        int result = 0;
        int[] tab = new int[] { 1, 2, 3, 4, 7, 8, 9, 11, 14, 15, 16, 17, 19, 22 };

        for (int i = 0; i < tab.Length; i++)
        {
            if (i % 2 == 1)
            {
                result = result + i;
            } 
        }
        Console.Write("Suma liczb nieparzystych: " + result);
        Console.ReadLine();
    }
}
