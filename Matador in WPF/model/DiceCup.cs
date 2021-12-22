using System;

namespace Matador_in_WPF.model
{
    public class DiceCup
    {
        public Dice FirstDice { get; } 
        public Dice SecondDice { get; }

        public DiceCup()
        {
            FirstDice = new Dice();
            SecondDice = new Dice();
        }

        public void RollCup()
        {
            FirstDice.Roll();
            SecondDice.Roll();
        }

        public override string ToString()
        {
            return "dice 1 rolled: " + FirstDice.Value + "\n" +
                   "dice 2 rolled: " + SecondDice.Value + "\n" +
                   "Your total is: " + (FirstDice.Value + SecondDice.Value);
        }
    }
};

