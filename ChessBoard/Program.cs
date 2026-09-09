using System;

Console.WriteLine("Ange storlek på brädet genom att skriva ett tal mellan 3-50");
String input = Console.ReadLine();

int.TryParse(input, out int size);

Console.WriteLine("Storleken på brädet är: " + size);

if (size >= 3 && size <= 50)
{
	Console.WriteLine("Godkänd storlek!");
}
else
{
	Console.WriteLine("Felaktig storlek, mata in ett tal mellan 3-50");
}

