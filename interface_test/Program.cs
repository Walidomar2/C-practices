using System;
using System.Reflection;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var casher_1 = new Casher(new Cash());
            casher_1.CheckOut(1000.52m);

            System.Console.WriteLine("\n----------------------------------------------");

            var casher_2 = new Casher(new Visa());
            casher_1.CheckOut(1056.52m);

            System.Console.WriteLine("\n----------------------------------------------");

            var casher_3 = new Casher(new Dibt());
            casher_1.CheckOut(5556.52m);

        }
    }

    interface Ipayment
    {
        void PayMethod(decimal amount);
    }

    class Cash : Ipayment
    {
        public void PayMethod(decimal amount)
        {
            System.Console.WriteLine($"Cash payment: {Math.Round(amount,2):N0}$");
        }
    }

    class Visa : Ipayment
    {
        public void PayMethod(decimal amount)
        {
            System.Console.WriteLine($"Visa payment: {Math.Round(amount,2):N0}$");
        }
    }

    class Dibt : Ipayment
    {
        public void PayMethod(decimal amount)
        {
            System.Console.WriteLine($"Dibt payment: {Math.Round(amount,2):N0}$");
        }
    }

    class Casher
    {
        private Ipayment _payment;

        public Casher(Ipayment payment)
        {
            _payment = payment;
        }

        public void CheckOut(decimal amount)
        {
            _payment.PayMethod(amount);
        }

    }

}