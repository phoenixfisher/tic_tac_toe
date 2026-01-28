using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Player 1 is X, Player 2 is O\n");

            // Create the game board array
            char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Board gameBoard = new Board();

            int currentPlayer = 1;
            char currentMarker;
            bool gameWon = false;

            while (!gameWon)
            {
                currentMarker = currentPlayer == 1 ? 'X' : 'O';

                // Print the board
                gameBoard.PrintBoard(board);
                Console.WriteLine("");

                Console.Write($"Player {currentPlayer}, enter your choice (1-9): ");
                string input = Console.ReadLine();
                Console.WriteLine("");


                int position;
                bool validInput = int.TryParse(input, out position);

                if (!validInput || position < 1 || position > 9 || board[position - 1] == 'X' || board[position - 1] == 'O')
                {
                    Console.WriteLine("Invalid choice. Try again.\n");
                    continue;
                }

                // Update board
                board[position - 1] = currentMarker;

                // Check for winner
                gameWon = gameBoard.DetermineWinner(board);

                if (gameWon)
                {
                    gameBoard.PrintBoard(board);
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    break;
                }
                else if(Array.TrueForAll(board, c => c == 'X' || c == 'O'))
                {
                    Console.WriteLine("It's a draw!");
                    break; 
                }

                    // Switch player
                    currentPlayer = currentPlayer == 1 ? 2 : 1;
            }

            Console.WriteLine("\nThanks for playing!");
        }
    }
}