
namespace FactoryDesignPatternApp_Simple
{
    
    public interface IDesserts : IDish
    {
    }
    public class FruitSalad : Dish, IDesserts
    {
        public FruitSalad(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        {
        }

        public void Serve()
        {
            Console.WriteLine($"Fruit Salad \n▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class Tiramisu : Dish, IDesserts
    {
        public Tiramisu(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        {
        }

        public void Serve()
        {
            Console.WriteLine($"Tiramisu \n▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class Browny : Dish, IDesserts
    {
        public Browny(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        {
        }

        public void Serve()
        {
            Console.WriteLine($"Browny \n▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class IceCream : Dish, IDesserts
    {
        public IceCream(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
        public void Serve()
        {
            Console.WriteLine($"Ice Cream \n▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
}
