namespace CoffeeShop.Models
{
    public class RegularCoffee : Coffee
    {
        public override string Name => "RegularCoffee";

        public override int CoffeeContent => 50;

        public override int MilkContent => 0;
    }
}
