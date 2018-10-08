using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCpuDetails();
        }
        private static void GetCpuDetails()
        {
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                Console.WriteLine("Number Of Physical Processors: {0} ", item["NumberOfProcessors"]);
                Console.WriteLine("Number Of Logical Processors: {0} ", item["NumberOfLogicalProcessors"]);
            }

            var numberOfCores = 0;
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                numberOfCores += int.Parse(item["NumberOfCores"].ToString());
                Console.WriteLine("Bitness: {0}", item["AddressWidth"]);
                Console.WriteLine("Architecture: {0}", GetArchitectureDetail(int.Parse(item["Architecture"].ToString())));
            }

            Console.WriteLine("Number Of Cores: {0}", numberOfCores);


        }

        private static string GetArchitectureDetail(int architectureNumber)
        {
            switch (architectureNumber)
            {
                case 0: return "x86";
                case 1: return "MIPS";
                case 2: return "Alpha";
                case 3: return "PowerPC";
                case 6: return "Itanium-based systems";
                case 9: return "x64";
                default:
                    return "Unkown";
            }
        }
    }
}