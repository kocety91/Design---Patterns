

using EmployeeCloning.Models;

var developer = new Developer("Koce", "Developer", 90);
var devCopy = developer.Clone() as Developer;
devCopy.Name = "Misho";
devCopy.Role = "BIG BOSS";
devCopy.WordsPerMinute = 40;
Console.WriteLine(developer.GetDetails());
Console.WriteLine(devCopy.GetDetails());

var typist = new Typist("Sasho", "SomePosition", 20);
var typistCopy = typist.Clone() as Typist;

Console.WriteLine(typistCopy.GetDetails());
Console.WriteLine(typist.GetDetails());