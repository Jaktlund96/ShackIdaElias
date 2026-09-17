using System;
using System.Data;
using System.Security.AccessControl;
using Spectre.Console;

namespace ChessBoard
{ 
    class Program
    {
        static void Main()
        {
            

            int size = Chess.ReadSize();

            Chess board = new Chess(size);

            Console.OutputEncoding = System.Text.Encoding.Unicode;

          

            board.RenderBoard();


            
              
            
         
        }
    }
}