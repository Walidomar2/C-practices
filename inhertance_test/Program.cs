using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager_1 = new Manager(1002,"Omar A.karam",180,10);
            Console.WriteLine(manager_1);
            Console.WriteLine("\n------------------------------------------------------------------");
            var sales_1 = new Sales(1002,"Omar A.karam",176,8,100m,0.05m);
            Console.WriteLine(sales_1);
            Console.WriteLine("\n------------------------------------------------------------------");
            var developer_1 = new Developer(100,"Walid Omar",190,20,true);
            Console.WriteLine(developer_1);
            
        }
    }
}