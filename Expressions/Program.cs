using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = null; 
            s1 = s1 ?? "Walid"; // ?? used to check null 

            Console.WriteLine(s1); //walid

            s1=s1??"omar";
            Console.WriteLine(s1); // still walid
            Console.WriteLine("*************************");

            string s2 = null;
            string s3 = s2 ?.ToUpper();
            Console.WriteLine(s3); // Blank space

            string s4 = "walid";
            string s5 = s4 is null? null : s4.ToUpper();
            Console.WriteLine(s5); // WALID

            Console.WriteLine("*************************");

            var cardNo = 13;
            string cardName = cardNo switch{
                1  => "ACE",
                13 => "KING",
                12 => "QUEEN",
                10 => "JACK",
                 _ => cardNo.ToString() 
            };

            Console.WriteLine(cardName);

            Console.WriteLine("*************************");

            object o = "walid";

            switch(o)
            {
                case int i: Console.WriteLine($"the square of {i} = {i*i}"); break;
                case string i: Console.WriteLine(i.ToUpper()); break;
            }
        }
    }

}