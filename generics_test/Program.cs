using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new Any<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            Console.WriteLine($"Is the list Empty: {numbers.IsEmpty}");
            Console.WriteLine($"number of Items: {numbers.Count} item");

            numbers.DisplayItems();

            numbers.Remove(3);

            numbers.DisplayItems();
        }
    }
}

