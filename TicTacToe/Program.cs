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
    private int[] _board { get; set; } = new int[8];

    public void ShowBoard()
    {
        foreach(var item in _board)
        {
            Console.WriteLine(item);
        }
    }

}
