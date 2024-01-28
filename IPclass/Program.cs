using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip = new IP(192,168,1,1);
            Console.WriteLine(ip.IPAddress);
            Console.WriteLine($"firts segment: {ip[0]}");

            var ip_2 = new IP("192.168.1.2");
            Console.WriteLine(ip_2.IPAddress);
            Console.WriteLine($"4th segment: {ip_2[3]}");
        }
    }
}