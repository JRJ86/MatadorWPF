using System;
using System.Collections;
using System.Collections.Generic;
using Matador_in_WPF.model.fields;

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

        public List<BuyableField> Properties { get; set; }

        private readonly DiceCup _diceCup;
    
        public Player(string name, int playerNumber, int walletAmount, int position, bool inJail)
        {
            Name = name;
            PlayerNumber = playerNumber;
            WalletAmount = walletAmount;
            Position = position;
            InJail = inJail;
            _diceCup = new DiceCup();
            Properties = new List<BuyableField>();
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
        /**
         * TODO: Maybe remove this!
         */
        public string DisplayProperties()
        {
            return Properties.ToString();
        }

        public override string ToString()
        {
            return "Player " + Name + " has the number " + PlayerNumber + "\n" +
                   Name + "'s wallet contains " + WalletAmount + " kr.\n" +
                   Name + "'s current position is " + Position + " on the board\n" +
                   Name + "'s current roll is " + CurrentRoll + "\n" +
                   Name + "'s jail status is " + InJail + "\n" +
                   Name + "'s has the" ;
        }
    }
};

