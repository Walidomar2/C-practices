using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            var m1 = new Money(9);
            var m2 = new Money(9);
            m2++;
            m1--;

            Console.WriteLine($"m2++ = {m2.Amount}");
            Console.WriteLine($"m1-- = {m1.Amount}");

            Money m4 = m2 + m1;
            Money m5 = m2 - m1;

            Console.WriteLine(m4.Amount);
            Console.WriteLine(m5.Amount);

            Console.WriteLine(m1 > m2);
            Console.WriteLine(m4 != m5);


        }
    }
}


