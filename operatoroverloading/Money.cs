using System;

namespace App
{
    public class Money
    {
        private decimal _amount;
        public decimal Amount => _amount;

        public Money(decimal money)
        {
            _amount = money;
        }

        public static Money operator +(Money money1, Money money2)
        {
            var value = money1.Amount + money2.Amount;
            return new Money(value); 
        }

        public static Money operator -(Money money1, Money money2)
        {
            var value = money1.Amount - money2.Amount;
            return new Money(value);
        }

        public static bool operator >(Money money1, Money money2)
        {
            return (money1.Amount > money2.Amount); 
        }

        public static bool operator <(Money money1, Money money2)
        {
            return (money1.Amount < money2.Amount); 
        }

        public static bool operator ==(Money money1, Money money2)
        {
            return (money1.Amount == money2.Amount); 
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return (money1.Amount != money2.Amount); 
        }

        public static Money operator ++(Money money)
        {
            var value = money.Amount;
            return new Money(++value);
        }

        public static Money operator --(Money money)
        {
            var value = money.Amount;
            return new Money(--value);
        }
    }
}