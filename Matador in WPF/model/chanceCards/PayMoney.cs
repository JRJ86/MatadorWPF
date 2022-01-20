namespace Matador_in_WPF.model.chanceCards
{
    public class PayMoney : ChanceCard
    {
        public int Amount { get; set; }

        public PayMoney(int amount)
        {
            Amount = amount;
        }

        public override string ToString()
        {
            return "CHANCE CARD \n" + Description + "\nPay " + Amount + " kr to the bank! \n";
        }
    }
};

