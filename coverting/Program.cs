using System;
using System.Net;

namespace convertingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string value="999";
            //int num = int.Parse(value);
            //Console.WriteLine(num);

            // but best way to check first is it ok to be converted or not

            if(int.TryParse(value,out int num))
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Faild");
            }


            Console.WriteLine("*****************************************");

            //converto function (conver.ToSingle() - conver.ToInt32() - convert.ToUInt16() ....)

            string value2="12.8";

            float num2 = Convert.ToSingle(value2);
            Console.WriteLine(num2);

            Console.WriteLine("*****************************************");

            int num3 = 10;

            var bytes = BitConverter.GetBytes(num3);

            foreach(var i in bytes)
            {
               // Console.WriteLine(i);  10 - 0 - 0 - 0
               //if i want to change it to bits 8bits for each byte

               var binary = Convert.ToString(i, 2).PadLeft(8,'0');
               Console.WriteLine(binary);
            }
            Console.WriteLine("*****************************************");

            string name = "walid";
            int ascii = 0;

            var namechar = name.ToCharArray();

            foreach(var letter in namechar)
            {
                ascii = Convert.ToInt32(letter);
                Console.WriteLine($"letter {letter} ==> ascii value = {ascii} ==> Hexadecimal value = {ascii:x}");
            }

            Console.WriteLine("*****************************************");
            
        }
    }
}