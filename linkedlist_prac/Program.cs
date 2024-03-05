using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main()
        {
            var Lesson2 = new YTP( "YTV2", "Classes and Strcts", new TimeSpan(01, 20, 00));
            var Lesson1 = new YTP( "YTV1", "Variables", new TimeSpan(00, 30, 00));
            var Lesson3 = new YTP( "YTV3", "Expressions", new TimeSpan(00, 45, 00));
            var Lesson4 = new YTP( "YTV4", "Iterations", new TimeSpan(01, 10, 00));
            var Lesson5 = new YTP( "YTV5", "Generics", new TimeSpan(00, 20, 00));

            LinkedList<YTP> PlayList = new LinkedList<YTP>(new YTP[] {
                Lesson2,
                Lesson1,
                Lesson3,
                Lesson4,
                Lesson5
            });

            PrintList("C# Tutorial", PlayList);

        }

        static void PrintList(string title, LinkedList<YTP> playlist)
        {
            Console.WriteLine($"┌{title}");
            foreach (var item in playlist)
                Console.WriteLine(item);
            Console.WriteLine($"└");
            Console.WriteLine($"Total: {playlist.Count} item(s)");
        }
    }

    public class YTP
    {
        private string _id;
        private string _name;
        private TimeSpan _duration;

        public YTP(global::System.String id, global::System.String name, TimeSpan duration)
        {
            _id = id;
            _name = name;
            _duration = duration;
        }

        public override string ToString()
        {
            return $"├── {_name} ({_duration})\n│\thttps://www.youtube.com/watch?v={_id}";
        }
    }
}