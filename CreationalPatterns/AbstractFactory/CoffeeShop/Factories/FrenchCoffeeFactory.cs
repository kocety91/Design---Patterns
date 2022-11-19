using CoffeeShop.AbstractProductModels;
using CoffeeShop.Models;

namespace CoffeeShop.Factories
{
    public class FrenchCoffeeFactory : CoffeeFactory
    {
        public override MilkCoffee GetMilkCoffee()
        {
            return new Macchiato();
        }

        public override PlainCoffee GetPlainCoffee()
        {
            return new RegularCoffee();
        }
    }
}
