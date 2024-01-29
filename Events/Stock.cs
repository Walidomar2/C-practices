using System;
using System.Reflection.Metadata.Ecma335;

namespace App
{

    //creating a delegate to use with event
    public delegate void stockPriceChangeHandler(Stock stock, decimal oldprice);

    public class Stock
    {
        private string _name;
        private decimal _price;

        public string name{ get => _name;}
        public decimal price{ get => _price; set => _price = value;}

        public event stockPriceChangeHandler onPriceChange;

        public Stock(string name)
        {
            _name = name;
        }

        public void ChangePriceBy(decimal percent)
        {
            var oldPrice = _price;
            _price += Math.Round( _price * percent, 2);

            if(onPriceChange != null)
            {
                onPriceChange(this, oldPrice);
            }
        }
    }
}