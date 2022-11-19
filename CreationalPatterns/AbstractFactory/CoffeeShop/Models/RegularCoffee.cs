using CoffeeShop.AbstractProductModels;

namespace CoffeeShop.Models
{
    public class RegularCoffee : PlainCoffee
    {
        public override string Name => "RegularCoffee";

        public override int CoffeeContent => 100;

        public override int MilkContent => 0;
    }
}
