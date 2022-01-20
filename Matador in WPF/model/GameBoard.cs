using System.Collections;
using System.Collections.Generic;
using Matador_in_WPF.model.chanceCards;
using Matador_in_WPF.model.fields;

namespace Matador_in_WPF.model
{
    public class GameBoard
    {
        public List<Player> Players { get; set; }
        public Queue<ChanceCard> ChancePile { get; set; }
        public Field[] Board { get; set; }
        public List<int> ChancePositions { get;}
        public int ParkingMoney { get; set; }

        public GameBoard()
        {
            Players = new List<Player>();
            ChancePile = new Queue<ChanceCard>();
            Board = new Field[40];
            ChancePositions = new List<int>() {2, 7, 17, 22, 33, 36};
        }
    }
};

