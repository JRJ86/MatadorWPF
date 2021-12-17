using System;

namespace Matador_in_WPF.model
{
    public class Dice
    {
        public int Sides => 6;
        public int Value { get; set; }

        private readonly Random _random = new Random();

        public void Roll()
        {
            Value = _random.Next(Sides) + 1;
        }
    }
};

