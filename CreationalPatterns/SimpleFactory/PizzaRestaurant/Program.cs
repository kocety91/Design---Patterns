using PizzaRestaurant.Enums;
using PizzaRestaurant.Factories;

var hawaiPizza = PizzaFactory.CreatePizza(PizzaType.Hawai);
Console.WriteLine(hawaiPizza.Description);
var cheesePizza = PizzaFactory.CreatePizza(PizzaType.Cheese);
Console.WriteLine(cheesePizza.Description);
