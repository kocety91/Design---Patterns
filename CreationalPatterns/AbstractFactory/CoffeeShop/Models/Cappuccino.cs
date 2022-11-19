using CoffeeShop.AbstractProductModels;

namespace CoffeeShop.Models
{
    public class Cappuccino : MilkCoffee
    {
        public override string Name => "Cappuccino";

        public override int CoffeeContent => 100;

        public override int MilkContent => 200;
    }
}
