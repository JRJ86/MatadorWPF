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
    }
};

