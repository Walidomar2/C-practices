using System;

namespace App
{
    class Program
    {
        static void Main()
        {
            var context = new ApplicationDbContext();

            //var orderDetails_1 = context.Orders
            //                            .Include(o => o.OrderDetails)
            //                            .FirstOrDefault(x => x.Id == 1)
            //                            .OrderDetails;

            //Console.WriteLine(orderDetails_1.Count());

            Console.WriteLine("------------------- View Result -------------------------\n");
            foreach (var item in context.OrderWithDetails)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n------------------- Function Result -------------------------\n");

            var order1BillDetails = context.BillOrders
                .FromSqlInterpolated($"SELECT * FROM GetOrderBill({1})")
                .ToList();
            foreach (var item in order1BillDetails)
            {
                Console.WriteLine(item);
            }

            // if i didn't a Dbset for order bill
            //  var order1BillDetails = new AppDbContext().Set<OrderBill>()
                //.FromSqlInterpolated($"SELECT * FROM GetOrderBill({1})")
                //.ToList();

        }
    }
}