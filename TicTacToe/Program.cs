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
    private char[,] _results { get; set; } = new char[3, 3] { { 'X', 'X', 'X' }, { 'X', 'X', 'X'}, { 'X', 'X', 'X'} };

    public void ShowBoard()
    {
        Console.WriteLine("Tic Tac Toe");
        Console.WriteLine("-------------");
        Console.WriteLine("");
        Console.WriteLine($"  {_results[0,0]} | {_results[0,1]} | {_results[0,2]} ");
        Console.WriteLine($" --- --- ---");
        Console.WriteLine($"  {_results[1,0]} | {_results[1,1]} | {_results[1,2]} "); 
        Console.WriteLine($" --- --- ---");
        Console.WriteLine($"  {_results[2,0]} | {_results[2,1]} | {_results[2,2]} ");
    }

}
