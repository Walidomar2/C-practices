using System;
using System.Runtime.InteropServices;

namespace App
{

    public delegate void RectHelper(uint length, uint width);
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();

            RectHelper helper1 ;

            helper1 = rectangle.GetArea;
            helper1 += rectangle.GetPerimeter;

            helper1(10,10);

            Console.WriteLine("After removing a method from delegate");

            helper1 -= rectangle.GetArea;

            helper1(10,10);

        }

    }

    public class Rectangle
    {
        public void GetArea(uint length, uint width)
        {
            var result = length * width;
            Console.WriteLine($"The Rectangle Area of {length} , {width} = {result}");
        }

         public void GetPerimeter(uint length, uint width)
        {
            var result = 2*(length + width);
            Console.WriteLine($"The Rectangle Perimeter of {length} , {width} = {result}");
        }
    }
}