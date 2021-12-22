namespace Matador_in_WPF.model.fields
{
    public class Brewery : BuyableField
    {
        private string TheOwner()
        {
            return Owned ? this.Owner.Name : "None!";
        }

        public override string ToString()
        {
            return "Brewery: " + Name + " \n" +
                   "The price is: " + Price + " kr\n" +
                   "Owning 1 Brewery: \n" +
                   "Visiting player pays 100 times the dice values \n" +
                   "Owning 2 breweries: \n" +
                   "Visiting player pays 200 times the dice values \n" +
                   "You can pawn it for: " + PawnValue + " kr\n" +
                   "The property is owned by: " + TheOwner();
        }
    }
};

