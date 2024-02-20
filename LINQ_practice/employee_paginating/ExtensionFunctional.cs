using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_paginating
{
    public static class ExtensionFunctional
    {
        public static IEnumerable<Employee> Filter
            (this IEnumerable<Employee> source, Func<Employee, bool> predicate)
        {

            foreach (var employee in source)
            {
                if (predicate(employee))
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source,
          int page = 1, int size = 10) where T : class
        {
            if (page <= 0)
            {
                page = 1;
            }

            if (size <= 0)
            {
                size = 10;
            }

            var total = source.Count();

            var pages = (int)Math.Ceiling((decimal)total / size);

            var result = source.Skip((page - 1) * size).Take(size);

            return result;
        }

        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
            {
                if (typeof(T).IsValueType)
                    Console.Write($" {item} "); // 1, 2, 3
                else
                    Console.WriteLine(item);
            }


        }
    }
}
