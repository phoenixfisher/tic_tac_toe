namespace TicTacToe;

public class Board
{
    // Pair programmers:
    // Remember: don't look at the other pair's code
    // TODO:
    // 1. Receive the "board" array from the driver class.
    // 2. Contain a method that prints the board on the information passed to it.
    // 3. Contain a method that receives the game board array as input and returns
    // if there is a winner and who it was.

    public Board()
    {
        return;
    }
    public void PrintBoard(char[] board)
    {
        Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
    }

    public bool DetermineWinner(char[] board)
    {
        // Rows
        if (board[0] == board[1] && board[1] == board[2]) return true;
        if (board[3] == board[4] && board[4] == board[5]) return true;
        if (board[6] == board[7] && board[7] == board[8]) return true;

        // Columns
        if (board[0] == board[3] && board[3] == board[6]) return true;
        if (board[1] == board[4] && board[4] == board[7]) return true;
        if (board[2] == board[5] && board[5] == board[8]) return true;

        // Diagonals
        if (board[0] == board[4] && board[4] == board[8]) return true;
        if (board[2] == board[4] && board[4] == board[6]) return true;

        return false;
    }

}