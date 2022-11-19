namespace CoffeeShop.Models
{
    public class DoubleCoffee : Coffee
    {
        public override string Name => "DoubleCoffee";

        public override int CoffeeContent => 100;

        public override int MilkContent => 0;
    }
}
