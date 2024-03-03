using System;
using System.Reflection;

namespace App
{
    class Program
    {
        public static void Main()
        {
            List<Player> players = new List<Player>
            {
                new Player
                {
                    Name = "Lionel Messi",
                    BallControl = 9,
                    Dribbling = 18,
                    Passing = 4,
                    Speed = 85,
                    Power = 990
                },
                new Player
                {
                    Name = "Christiano Ronaldo",
                    BallControl = 9,
                    Dribbling = 21,
                    Passing = 4,
                    Speed = 110,
                    Power = 980
                },
                new Player
                {
                    Name = "Naymar Jr",
                    BallControl = 11,
                    Dribbling = 16,
                    Passing = 4,
                    Speed = 85,
                    Power = 1000
                }
            };

            List<Errors> errors = new List<Errors>();   

            foreach (var Player in players)
            {
                var PlayerProparties = Player.GetType().GetProperties();
                foreach(var Proparty in PlayerProparties)
                {
                    var SkillAttribute = Proparty.GetCustomAttribute<SkillesAttribute>();

                    if(SkillAttribute != null)
                    {
                        var value = Proparty.GetValue(Player);
                        if (value != null)
                        {
                            if (SkillAttribute.IsValid(value))
                            {
                                errors.Add
                                     (new Errors
                                        (Proparty.Name,
                                        $"Invalid value Accepted Range is {SkillAttribute.MinValue}-{SkillAttribute.MaxValue}"));
                            }
                        }
                    }
                }
            }

            if(errors.Count > 0)
            {
                Console.WriteLine($"Errors Number: {errors.Count}");
                foreach (var Error in errors)
                {
                    Console.WriteLine(Error);
                }
            }

            Console.ReadKey();
        }
    }
}