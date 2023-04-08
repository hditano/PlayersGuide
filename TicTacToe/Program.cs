// See https://aka.ms/new-console-template for more information

Board newB = new Board();
newB.ShowBoard();

class TicTacToe
{
    
}


class Player
{
    private string? _name { get; set; }
    private string? _symbol { get; set; }

    internal Player(string name, string symbol)
    {
        _name = name;
        _symbol = symbol;
    }
}

class Board
{
    private int[] _board { get; set; } = new int[9];
    private string[] _results { get; set; } = new string[9] {"A", "B", "C", "D", "E", "F", "G", "H", "I"};

    public void ShowBoard()
    {
        Console.WriteLine("Tic Tac Toe");
        Console.WriteLine("-------------");
        Console.WriteLine("");
        Console.WriteLine($"  {_results[0]} | {_results[1]} | {_results[2]} ");
        Console.WriteLine($" --- --- ---");
        Console.WriteLine($"  {_results[3]} | {_results[4]} | {_results[5]} "); 
        Console.WriteLine($" --- --- ---");
        Console.WriteLine($"  {_results[6]} | {_results[7]} | {_results[8]} ");
    }

}
