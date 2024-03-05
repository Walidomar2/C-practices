using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main()
        {
            Queue<Printing> printings = new Queue<Printing>();

            printings.Enqueue(new Printing("Test_1.pdf", 2));
            printings.Enqueue(new Printing("Test_2.pdf", 4));
            printings.Enqueue(new Printing("Test_3.pdf", 3));
            printings.Enqueue(new Printing("Test_4.pdf", 1));
            printings.Enqueue(new Printing("Test_5.pdf", 6));

            Console.WriteLine($"Number of files in the Queue before printing {printings.Count()}");
            while(printings.Count() > 0)
            {
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                var item = printings.Dequeue();

                Console.WriteLine("printing .... " + item);
                System.Threading.Thread.Sleep(1000);    
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Number of files in the Queue After printing {printings.Count()}");
        }
    }

    public class Printing
    {
        private readonly string _fileName = string.Empty;
        private readonly int _copies;

        public Printing(string fileName, int copies)
        {
            _fileName = fileName;
            _copies = copies;
        }

        public override string ToString()
        {
            return $" {_fileName}  x #{_copies} copies";
        }
    }
}
