using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main()
        {
            Stack<Url> undo = new Stack<Url>();
            Stack<Url> redo = new Stack<Url>();

            string line = string.Empty;
            while(true)
            {
                Console.Write("Enter Url  or ('exit' to quit): ");
                line = Console.ReadLine().ToLower();

                if (line == "exit")
                {
                    break;
                }
                else if (line == "back")
                {
                    if (undo.Count > 0)
                    {
                        var url = undo.Pop();
                        redo.Push(url);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (line == "forward")
                {
                    if (redo.Count > 0)
                    {
                        var url = redo.Pop();
                        undo.Push(url);
                    }
                    else
                    {
                        continue; 
                    }
                }
                else
                {
                    undo.Push(new Url(line));
                }
                
                Console.Clear();

                PrintStack("Back",undo);
                PrintStack("Forward", redo);
            }
        }

        static void PrintStack(string name, Stack<Url> urls)
        {
            Console.WriteLine($"{name} history");
            Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
            foreach (var u in urls)
            {
                Console.WriteLine($"\t{u}");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}