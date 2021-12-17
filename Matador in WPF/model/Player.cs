namespace Matador_in_WPF.model
{
    public class Player
    {
        public string Name { get; set; }
        public int PlayerNumber { get; set; }
        public int WalletAmount { get; set; }
        public int Position { get; set; }
        public int CurrentRoll { get; set; }
        public bool InJail { get; set; }

        private DiceCup _diceCup = new();
    
        public Player(string name, int playerNumber, int walletAmount, int position, bool inJail)
        {
            Name = name;
            PlayerNumber = playerNumber;
            WalletAmount = walletAmount;
            Position = position;
            InJail = inJail;
        }

        public void ThrowDice()
        {
            _diceCup.RollCup();
            CurrentRoll = _diceCup.FirstDice.Value + _diceCup.SecondDice.Value;
        }

        public string YourRoll()
        {
            return "First dice rolled: " + _diceCup.FirstDice.Value + "\n" +
                   "Second dice rolled: " + _diceCup.SecondDice.Value + "\n" +
                   "Total roll is: " + (_diceCup.FirstDice.Value + _diceCup.SecondDice.Value) + "\n";
        }
    }
};

