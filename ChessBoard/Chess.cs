using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    class Chess
    {
      public int Size { get; set; }

      public Chess(int size)
      {
            Size = size;
      }

        public static int ReadSize() //Metod 1. Läser in storleken och skriver ut storleken
        {
            while (true)
            {
                Console.WriteLine("Ange storlek på brädet genom att skriva ett tal mellan 3-50");
                String input = Console.ReadLine();
                if (int.TryParse(input, out int size) && size >= 3 && size <= 50)
                {
                    Console.WriteLine("Godkänt storlek!");
                    return size;
                }

                Console.WriteLine("Felaktig storlek, skriv ett tal mellan 3-50.");
            }
        }

        public void RenderBoard() //Metod 2
        {

            
                
                for (int rad = 0; rad < Size; rad++)
                {
                    for (int kolumn = 0; kolumn < Size; kolumn++)
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
    }
}