using System;

namespace DateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(3,5,2024);

            Console.WriteLine(d1.getDate());

            d1.setDay(4);
            Console.WriteLine(d1.getDate());
        }
    }
}