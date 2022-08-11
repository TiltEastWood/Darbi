using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char player1 = 'X';
        private static char player2 = 'O';
        private static bool winCondition = false;
        private static void Main(string[] args)
        {
            InitBoard();
            string result = GameLoop();
            Console.WriteLine(result);
            Console.ReadKey();
        }
        private static string GameLoop()
        {
            int moveCounter = 0;
            char currentMove = ' ';

            while (winCondition != true)
            {
                Console.WriteLine("Enter col and row");
                string userInput = Console.ReadLine();
                string[] UI1 = userInput.Split(' ');
                int row = Convert.ToInt32(UI1[0]);
                int col = Convert.ToInt32(UI1[1]);
                
                if (moveCounter % 2 == 0)
                {
                    currentMove = player1;
                }
                else
                {
                    currentMove = player2;
                }
                CheckWinner();
                if (moveCounter == 8 && winCondition != true)
                {
                    return "Draw!";
                }

                board[row, col] = currentMove;
                
                
                moveCounter++;
                DisplayBoard();
            }
            if (currentMove == 'X')
            {
                return "Player X win!";
            }
            else if (currentMove == '0')
            {
                return "Player O win!";
            }
            else
            {
                return "Error!";
            }
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }
        private static void CheckWinner()
        {
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != ' ')
            {
                winCondition = true;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != ' ')
            {
                winCondition = true;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != ' ')
            {
                winCondition = true;
            }
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != ' ')
            {
                winCondition = true;
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] != ' ')
            {
                winCondition = true;
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != ' ')
            {
                winCondition = true;
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            {
                winCondition = true;
            }
            else if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] != ' ')
            {
                winCondition = true;
            }
        }
        private static void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
