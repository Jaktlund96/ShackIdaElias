using System;
using System.Collections.Generic;
using System.Text;

class Chess
{
    public static int ReadSize() //Metod 1. Läser in storleken och skriver ut storleken
    {
  while (true)
    {
			Console.WriteLine("Ange storlek på brädet genom att skriva ett tal mellan 3-50");
			String input = Console.ReadLine();
            if (int.TryParse(input, out int size) && size >=3 && size <=50)
            {
                Console.WriteLine("Godkänt storlek!");
                return size;
            }

            Console.WriteLine("Felaktig storlek, skriv ett tal mellan 3-50.)
		}
    }
}
