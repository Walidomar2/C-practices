﻿﻿using System;
using System.Collections.Generic;

namespace CAGenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = Print;
            action("Issam");
            Func<int, int, int> addD = Add;
            Console.WriteLine(addD(2,2));
            Predicate<int> predicate = IsEven;
            Console.WriteLine(predicate(3));
            
            System.Console.WriteLine("\n-------------------------------------------\n");
            IEnumerable<int> list = new int[]{1,2,3,4,5,6,7,8,9};
			PrintNumbers(list,n=> n < 6);	// numbers less than 6
            System.Console.WriteLine("\n-------------------------------------------\n");
			PrintNumbers(list,n=> n < 7);	//numbers less than 7
            System.Console.WriteLine("\n-------------------------------------------\n");
			PrintNumbers(list,n=> n%2 == 0);		//Even numbers

            System.Console.WriteLine("\n-------------------------------------------\n");

            IEnumerable<decimal> list_2 = new decimal[]{1.5m,2.8m,3.9m,4.5m,8.5m,6.8m,7.5m,8.9m,9.1m};

            PrintNumbers(list_2, n =>  n < 6.2m); 
            System.Console.WriteLine("\n-------------------------------------------\n");     
            PrintNumbers(list_2, n =>  n < 8.2m);
            System.Console.WriteLine("\n-------------------------------------------\n");
        }

        static void Print(string name) => Console.WriteLine(name);
        static int Add(int n1, int n2) => n1 + n2;
        static bool IsEven(int n) => n % 2 == 0;

        static void PrintNumbers<T>(IEnumerable<T> numbers, Predicate<T> filter)
		{
			foreach(var number in numbers)
			{
				if(filter(number))
				{
					Console.WriteLine(number);
				}
			}
		}
    }


    
}