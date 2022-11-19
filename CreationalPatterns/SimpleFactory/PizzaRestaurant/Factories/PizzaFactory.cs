using PizzaRestaurant.Enums;
using PizzaRestaurant.Models;

namespace PizzaRestaurant.Factories
{
    public class PizzaFactory
    {
        public static Pizza CreatePizza(PizzaType pizzaType)
        {
            return pizzaType switch
            {
                PizzaType.Pepperoni => new PepperoniPizza(),
                PizzaType.Cheese => new CheesePizza(),
                PizzaType.Hawai => new HawaiPizza(),
                _=>null,
            };
        }
    }
}
