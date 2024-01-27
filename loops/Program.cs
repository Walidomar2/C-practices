using System;

namespace loops
{
    class Program{
        static void Main(string[] args)
        {

            // while loop
            var counter=0;
            while(counter < 10)
            {
                Console.Write(counter + " ");
                counter++;
            }

            Console.WriteLine("\n************************************");

            counter = 0;

            do
            {
                Console.Write(counter + " ");
                counter++;
            }while(counter < 10);

            Console.WriteLine("\n************************************");

            for(counter=0;counter<10;counter++)
            {
                Console.Write(counter + " ");
            }

            Console.WriteLine("\n************************************");

            int[] Arr = new int[5];
            foreach(var i in Arr)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine("\n************************************");

            // break - continue - goto - return
        }
    }
}