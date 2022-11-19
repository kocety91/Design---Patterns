using CoffeeShop.Factories;

var frenchFactory  = new FrenchCoffeeFactory();
var frenchMilkCoffee = frenchFactory.GetMilkCoffee();
var frenchPlainCoffee = frenchFactory.GetPlainCoffee();

frenchMilkCoffee.Print();
frenchPlainCoffee.Print();


var italianFactory = new ItalianCoffeeFactory();
var italianMilkCoffee = italianFactory.GetMilkCoffee();
var italianPlainCoffee = italianFactory.GetPlainCoffee();

italianMilkCoffee.Print();
italianPlainCoffee.Print();