using CoffeeShop.AbstractProductModels;
using CoffeeShop.Models;

namespace CoffeeShop.Factories
{
    public class ItalianCoffeeFactory : CoffeeFactory
    {
        public override MilkCoffee GetMilkCoffee()
        {
            return new Cappuccino();
        }

        public override PlainCoffee GetPlainCoffee()
        {
            return new RegularCoffee();
        }
    }
}
