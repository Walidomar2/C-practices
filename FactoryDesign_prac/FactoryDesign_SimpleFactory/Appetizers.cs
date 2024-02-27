
namespace FactoryDesignPatternApp_Simple
{
    public interface IAppetizers : IDish
    {

    }
    public class ChickenSalad : Dish, IAppetizers
    {
        public ChickenSalad(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        {
        }

        public void Serve()
        {
            Console.WriteLine($"Chicken Salad \n▀▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }


    public class ButterCracker : Dish, IAppetizers
    {
        public ButterCracker(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        {
        }

        public void Serve()
        {
            Console.WriteLine($"Butter Cracker \n▀▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class CheeseTwist : Dish, IAppetizers
    {
        public CheeseTwist(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        {
        }

        public void Serve()
        {
            Console.WriteLine($"Cheese Twist \n▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class PotatoBite : Dish, IAppetizers
    {
        public PotatoBite(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        {
        }

        public void Serve()
        {
            Console.WriteLine($"Potato Bite \n▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
}
