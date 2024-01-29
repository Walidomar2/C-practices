using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock_1 = new Stock("Amazon");
            stock_1.price = 100;

            //subscribe to event
            stock_1.onPriceChange += stockPriceChange;

            stock_1.ChangePriceBy(0.10m);
            stock_1.ChangePriceBy(-0.02m);
            stock_1.ChangePriceBy(0.00m);

            //unsubscribe to event
            stock_1.onPriceChange -= stockPriceChange;
            stock_1.ChangePriceBy(0.10m);
        }

        private static void stockPriceChange(Stock stock,decimal oldprice)
        {
            if(stock.price > oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if(stock.price < oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine($"{stock.name} ==> {stock.price}$ ");
        }
    }
}