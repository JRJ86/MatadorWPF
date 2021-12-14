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
    
        public Player(string name, int playerNumber, int walletAmount, int position, bool inJail)
        {
            Name = name;
            PlayerNumber = playerNumber;
            WalletAmount = walletAmount;
            Position = position;
            InJail = inJail;
        }
        
        
    }
};

