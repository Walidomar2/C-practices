using System;
using System.Collections.Generic;
using System.Linq;


namespace select_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> {1, 2, 3, 4, 5};
            var result = list.Select(x => x * x);

            foreach(var n in result)
            {
                Console.Write(n);
                Console.Write(' ');
            }

            Console.ReadKey();
        }
    }
}
