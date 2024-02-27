
namespace FactoryDesignPatternApp_Simple
{
    public interface IMainDish : IDish
    {
    }

    public class Lasagna : Dish, IMainDish
    {
        public Lasagna(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        {
        }

        public void Serve()
        {
            Console.WriteLine($"Lasagna \n▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
    public class Steak : Dish, IMainDish
    {
        public Steak(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }

        public void Serve()
        {
            Console.WriteLine($"Steak \n▀▀▀▀▀\n{ShowDetails()}");
        }
    }
    public class Molokhiya : Dish, IMainDish
    {
        public Molokhiya(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
        public void Serve()
        {
            Console.WriteLine($"Molokhiya \n▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
    public class GrilledChicken : Dish, IMainDish
    {
        public GrilledChicken(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
        public void Serve()
        {
            Console.WriteLine($"Grilled Chicken \n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
 }
