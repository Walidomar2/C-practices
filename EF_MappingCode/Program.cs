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
            

            foreach (var item in context.OrderWithDetails)
            {
                Console.WriteLine(item);
            }

        }
    }
}