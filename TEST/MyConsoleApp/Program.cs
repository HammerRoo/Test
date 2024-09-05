Console.WriteLine("Hello, World!");
var currentDate = DateTime.Now;
Console.WriteLine("The current time is:" + currentDate);
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
Console.WriteLine($"{Environment.NewLine} Hello {name}, on {currentDate}");