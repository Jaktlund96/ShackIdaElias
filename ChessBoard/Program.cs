using System;
using System.Data;
using System.Security.AccessControl;

Console.OutputEncoding = System.Text.Encoding.Unicode;

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
                Console.Write("\u25a1 ");
            }
            else
            {
                Console.Write("\u25a0 ");
            }
            
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Felaktig storlek, mata in ett tal mellan 3-50");
}