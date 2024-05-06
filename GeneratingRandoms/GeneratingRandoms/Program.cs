using System;
using System.Text;

namespace GeneratingRandoms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
                Console.WriteLine("Please select an Option.. ");
                Console.Write("[1] Generating Random Number     [2] Generating Random String: ");
                var selectedOption = Console.ReadLine();

                if(selectedOption == "1")
                {
                    try
                    {
                        Console.Write("Please Enter the min Value of number: ");
                        int minValue = int.Parse(Console.ReadLine());
                        Console.Write("Please Enter the max Value of number: ");
                        int maxValue = int.Parse(Console.ReadLine());
                        GenerateRandomNumber(minValue, maxValue);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Please enter Valid Numbers ");

                    }
                }
                else if(selectedOption == "2")
                {
                    Console.Write("Include Capital letters ? (yes/no): ");
                    var Capital = Console.ReadLine();
                    Console.Write("Include Small letters ? (yes/no): ");
                    var Small = Console.ReadLine();
                    Console.Write("Include Numbers ? (yes/no): ");
                    var Numbers = Console.ReadLine();
                    Console.Write("Include Sympols ? (yes/no): ");
                    var Sympols = Console.ReadLine();
                    string buffer = GenerateBuffer(Capital, Small, Numbers, Sympols);
                    Console.Write("Enter the length: ");
                    var length = int.Parse(Console.ReadLine());
                    GenerateRandomString(length, buffer);

                }
                else
                    Console.WriteLine("Please Enter Valid Option.");

                Console.WriteLine("====================================\n");
            }
        }

        private static void GenerateRandomString(int length, string buffer)
        {
            StringBuilder sb = new StringBuilder();
            var ran = new Random();
            if (buffer.Length <= 0)
                Console.WriteLine("please try again with one yes at least");
            else
            {
                for (int i = 0; i < length; i++)
                {
                    sb.Append(buffer[ran.Next(0, buffer.Length - 1)]);
                }
            }
            Console.WriteLine(sb);
         }

        private static string GenerateBuffer(string? capital, string? small, string? numbers, string? sympols)
        {
            string buffer = "";
            string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string smallLetters = "abcdefghijklmnopqrstuvwxyz";
            string numbersForBuffer = "0123456789";
            string sympolsForBuffer = "~!@#$%^&*()";
            if (capital == "yes")
                buffer += capitalLetters;
            if (small == "yes")
                buffer += smallLetters;
            if (numbers == "yes")
                buffer += numbersForBuffer;
            if (sympols == "yes")
                buffer += sympolsForBuffer;

            return buffer;
        }

        private static void GenerateRandomNumber(int min , int max)
        {
            var rnd = new Random();
            Console.WriteLine($"Random Number = {rnd.Next(min, max)}");
        }
    }
}
