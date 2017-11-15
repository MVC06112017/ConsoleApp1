using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool HasWinnerOrBoardFull(int[,] board)
        {
            bool result = true; // Assume done

            for (int i = 0; i < 3 && result; i++)
            {
                for (int j = 0; j < 3 && result; j++)
                {
                    if (board[i, j] == 0)
                    {
                        result = false; // 0 found we are not done
                    }
                }
            }

            if (result)
            {
                return true;
            }

            result = (board[0, 0] + board[0, 1] + board[0, 2] == 3 ||
                       board[0, 0] + board[0, 1] + board[0, 2] == 6 ||
                       board[0, 0] + board[1, 1] + board[2, 2] == 3 ||
                       board[0, 0] + board[1, 1] + board[2, 2] == 6 ||
                       board[0, 0] + board[1, 0] + board[2, 0] == 3 ||
                       board[0, 0] + board[1, 0] + board[2, 0] == 6 ||
                       board[1, 0] + board[1, 1] + board[1, 2] == 3 ||
                       board[1, 0] + board[1, 1] + board[1, 2] == 6 ||
                       board[2, 0] + board[2, 1] + board[2, 2] == 3 ||
                       board[2, 0] + board[2, 1] + board[2, 2] == 6 ||
                       board[2, 0] + board[1, 1] + board[0, 2] == 3 ||
                       board[2, 0] + board[1, 1] + board[0, 2] == 6 ||
                       board[0, 1] + board[1, 1] + board[2, 1] == 3 ||
                       board[0, 1] + board[1, 1] + board[2, 1] == 6 ||
                       board[0, 2] + board[1, 2] + board[2, 2] == 3 ||
                       board[0, 2] + board[1, 2] + board[2, 2] == 6);
            
            return result;
        }

        static void Main(string[] args)
        {
            // Game board, 0=empty, 1=X, 2=O 
            int[,] gameBoard = new int[3, 3];

            int playerInTurn = 0; // Player 0 = X, Player 1 = O

            //gameBoard[1, 2] = 1;
            //gameBoard[2, 1] = 2;

            while (!HasWinnerOrBoardFull(gameBoard))
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("+-+-+-+");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("|" +
                            (gameBoard[i, j] == 0 ? "" + (i * 3 + j + 1) :
                            (gameBoard[i, j] == 1 ? "X" : "O")));
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
                Console.WriteLine("+-+-+-+");

                Console.WriteLine("Make your turn player " + playerInTurn);
                var key = Console.ReadKey();

                if (key.KeyChar > '0' && key.KeyChar <= '9')
                {
                    int pos = key.KeyChar - 48;
                    int j = (pos - 1) % 3;
                    int i = (pos - 1) / 3;
                    gameBoard[i, j] = playerInTurn + 1;
                }

                playerInTurn = (playerInTurn + 1) % 2;

            }

            Console.WriteLine("Game over");
            Console.ReadKey();




















            /* Console.WriteLine("Hello World!");

            var config = new ServerConfiguration();

            config.LoadConfiguration();

            config.ApplicationName = "ConsoleApp1";

            Console.WriteLine(config.ApplicationName);

            config.DatabaseServerName = "128.162.37.4";

            config.SaveConfiguration();

            Console.ReadKey();
            */
        }
    }
}
