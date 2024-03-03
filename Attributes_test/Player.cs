using System;
using System.Collections.Generic;

namespace App
{
    public class Player
    {
        public string Name { get; set; } = string.Empty;

        [Skilles(nameof(Speed),1,100)]
        public int Speed { get; set; }

        [Skilles(nameof(Dribbling), 1, 10)]
        public int Dribbling { get; set; }

        [Skilles(nameof(BallControl), 1, 20)]
        public int BallControl { get; set; }

        [Skilles(nameof(Power), 1, 100)]
        public int Power { get; set; }

        [Skilles(nameof(Passing), 1, 10)]
        public int Passing { get; set; }
    }
}
