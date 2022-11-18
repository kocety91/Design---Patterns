using Logger;

var loggerOne = Logger.Logger.Instance;
var loggerTwo = Logger.Logger.Instance;

Console.WriteLine($"Are loggers  equal:  {loggerOne.Equals(loggerTwo)}");


var firstLog = Log.Instance;
var secondLog = Log.Instance;

Console.WriteLine($"Are logs  equal:  {firstLog.Equals(secondLog)}");
