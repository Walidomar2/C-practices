using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list_1 = new List<int> { 1, 2, 3, 4, 5, 6, 7,8,9};
            var evenNumbers = list_1.Where(x => x % 2 == 0);

            list_1.Add(10);
            list_1.Add(11);
            list_1.Add(12);
            list_1.Remove(4);


            // Where keep tracking the list and changes so the output will be ==> 2,6,8,10,12
            foreach(var number in evenNumbers)
            {
                Console.Write(number);
                Console.Write(' ');
            }

            Console.ReadKey();
        }
    }
}
