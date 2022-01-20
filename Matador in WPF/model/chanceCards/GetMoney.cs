namespace Matador_in_WPF.model.chanceCards
{
    public class GetMoney : ChanceCard
    {
        public int Amount { get; set; }

        public GetMoney(int amount)
        {
            Amount = amount;
        }

        public override string ToString()
        {
            return "CHANCE CARD \n" + Description + "\nRetrieve " + Amount + " kr from the bank! \n";
        }
    }
};

