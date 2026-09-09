using System;
using System.Data;
using System.Security.AccessControl;


	Console.WriteLine("Ange storlek på brädet genom att skriva ett tal mellan 3-50");
	String input = Console.ReadLine();

	int.TryParse(input, out int storlek);

	Console.WriteLine("Storleken på brädet är: " + storlek);

if (storlek >= 3 && storlek <= 50)
{
    Console.WriteLine("Godkänd storlek!");
    for (int rad = 0; rad < storlek; rad++)
    {
        for (int kolumn = 0; kolumn < storlek; kolumn++)
        {
            if ((rad + kolumn) % 2 == 0)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Felaktig storlek, mata in ett tal mellan 3-50");
}