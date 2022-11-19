namespace CoffeeShop.Models
{
    public class Cappuccino : Coffee
    {
        public override string Name => "Cappuccino";

        public override int CoffeeContent => 90;

        public override int MilkContent => 90;
    }
}
