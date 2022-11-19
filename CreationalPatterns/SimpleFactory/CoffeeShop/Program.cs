using CoffeeShop.Enums;
using CoffeeShop.Factories;

var regularCoffee = CoffeeFactory.GetCoffee(CoffeeType.Regular);

Console.WriteLine(regularCoffee.Name);
Console.WriteLine(regularCoffee.CoffeeContent);
Console.WriteLine(regularCoffee.MilkContent);

var doubleCoffee = CoffeeFactory.GetCoffee(CoffeeType.Double);

Console.WriteLine(doubleCoffee.Name);
Console.WriteLine(doubleCoffee.CoffeeContent);
Console.WriteLine(doubleCoffee.MilkContent);
