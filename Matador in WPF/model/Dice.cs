using System;

namespace Matador_in_WPF.model
{
    public class Dice
    {
        public int Sides { get; } = 6;
        public int Value { get; set; }

        private readonly Random _random = new Random();

        public void Roll()
        {
            Value = _random.Next(Sides) + 1;
        }

        private string ValueOrNull()
        {
            var value = (Value < 0 || Value > 6) ? "None" : "" + Value;
            return value;
        }

        public override string ToString()
        {
            return "This dice has " + Sides + " sides, and a current eye value of " + ValueOrNull() + "!";
        }
    }
};

