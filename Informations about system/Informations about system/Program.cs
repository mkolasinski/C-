using System;
using System.Net;

namespace Informations_about_system
{
    class Program
    {
        static void Main(string[] args)
        {
            string HostName = Dns.GetHostName();

            IPHostEntry IPAdresses = Dns.GetHostEntry(HostName);

            int counter = 0;

            Console.WriteLine("Your Host Name is: " + HostName);

            foreach ( IPAddress AddressIP in IPAdresses.AddressList)
            {
                if ( AddressIP.ToString() == "127.0.0.1" )
                {
                    Console.WriteLine("You are not connected to network: " + AddressIP.ToString());
                } else
                {
                    Console.WriteLine("Your IP Address " + ++counter + ":" + AddressIP.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
