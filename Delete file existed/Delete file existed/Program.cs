using System;
using System.IO;
using System.Text;

namespace Delete_file_existed
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytext.txt";
            Console.WriteLine("Remove file which exists");
            Console.WriteLine("--------------------------------");

            //Delete
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine("File {0} was deleted successfully!", fileName);
            } else
            {
                Console.WriteLine("File {0} does not exist.", fileName);
                Console.ReadKey();
            }
        }
    }
}
