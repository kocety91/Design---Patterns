using CoffeeShop.AbstractProductModels;

namespace CoffeeShop.Factories
{
    public abstract class CoffeeFactory
    {
        public abstract MilkCoffee GetMilkCoffee();
        public abstract PlainCoffee GetPlainCoffee();
    }
}
