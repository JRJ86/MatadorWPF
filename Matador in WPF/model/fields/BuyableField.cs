namespace Matador_in_WPF.model.fields
{
    public abstract class BuyableField : Field
    {
        public int Price { get; set; }
        public int PawnValue { get; set; }
        public bool Owned { get; set; }
        public Player Owner { get; set; }
        public bool Pawned { get; set; }
    }
};

