using PizzaRestaurant.Enums;
using PizzaRestaurant.Factories;

var pepperoniPizza = PizzaFactory.CreatePizza(PizzaType.Pepperoni);
var hawaiPizza = PizzaFactory.CreatePizza(PizzaType.Hawai);
var cheesePizza = PizzaFactory.CreatePizza(PizzaType.Cheese);


Console.WriteLine(pepperoniPizza.Description);
Console.WriteLine(hawaiPizza.Description);
Console.WriteLine(cheesePizza.Description);