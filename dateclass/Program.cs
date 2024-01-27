using System;

namespace DateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(10,03,2024);

            Console.WriteLine(d1.getDate());

            Console.WriteLine("----------------------------------------");
            d1.Month = 6;
            d1.Day = 3;
            d1.Year = 2024;

            Console.WriteLine(d1.getDate());

            Console.WriteLine("----------------------------------------");

            d1.Day = 0;
            Console.WriteLine(d1.getDate());
        }
    }
}