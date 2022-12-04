using System;
using BoardLogic;
namespace TicTacToe
{
    internal class Program 
    {
        static Board game = new Board();
        static void Main(string[] args)
        {
            
            

            int userTurn=-1;

            int computerTurn=-1;
            Random rand= new Random();
            while (game.checkForWinner() == 0)
            {
                //dont allow the human to chose already occupied square
                while (userTurn ==-1 || game.Grid[userTurn] != 0)
                {
                    Console.WriteLine("please enter number from 0 to 8");
                    userTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your typed" + userTurn);
                }


                game.Grid[userTurn] = 1;
                if (game.isBoardFull())
                    break;

                //dont let the computer pick an invalid number
                while (computerTurn==-1 || game.Grid[computerTurn]!=0)
                {
                    computerTurn= rand.Next(8);

                }
                Console.WriteLine("Computer chooses "+computerTurn);
                game.Grid[computerTurn] = 2;
                if (game.isBoardFull())
                    break;
                printBoard();
            }
            Console.WriteLine("The game is over Player " + game.checkForWinner()+" win");
            Console.ReadLine();

            
        }
        private static void printBoard()
        {
            for (int i = 0; i < game.Grid.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
                if (game.Grid[i] == 0)
                {
                    Console.Write('.');
                }
                else if (game.Grid[i] == 1)
                {
                    Console.Write('X');
                }
                else 
                {
                    Console.Write('O');
                }
            }
        }
    }
}
