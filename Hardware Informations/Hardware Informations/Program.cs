#region Usings

using System;
using System.Management;
using System.Management.Instrumentation;

#endregion

namespace Hardware_Informations
{
    class Program
    {
        static void Main(string[] args)
        {
            General();
            OsVersion();
            PcName();
            WindowsFolder();
            LogicalDrives();
            Console.ReadKey();
        }

        public static void General()
        {
            Console.WriteLine("Display general informations about your system.........");
            Console.WriteLine("");
        }

        public static void OsVersion()
        {
            Console.WriteLine("Windows Version: {0}", Environment.OSVersion.ToString());
        }

        public static void PcName()
        {
            Console.WriteLine("PcName is: {0}", Environment.MachineName);
        }

        public static void WindowsFolder()
        {
            Console.WriteLine("Windows folder is: {0}", Environment.SystemDirectory);
        }

        public static void LogicalDrives()
        {
            Console.WriteLine("Logical Drives: {0}", Environment.GetLogicalDrives());
        }
    }
}
