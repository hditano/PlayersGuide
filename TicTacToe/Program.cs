// See https://aka.ms/new-console-template for more information

new TicTacToe().Run();

class TicTacToe
{

    private Player player1 { get; } = new Player("Hernan", 'X');
    private Player player2 { get; } = new Player("Zoe", 'O');
    private int counter { get; set; } = 0;

    public void Run()
    {
        Board new1 = new Board();
        new1.CreateSymbol(player1);
        new1.CheckPosition(player1);
        new1.ShowBoard();

    }
}


class Player
{
    internal string? _name { get; set; }
    internal char _symbol { get; set; }

    internal Player(string name, char symbol)
    {
        _name = name;
        _symbol = symbol;
    }
}

class Board
{
    private int[] _board { get; set; } = new int[9];
    private char[,] _results { get; set; } = new char[3, 3];

    public void ShowBoard()
    {
        Console.WriteLine("Tic Tac Toe");
        Console.WriteLine("-------------");
        Console.WriteLine("");
        Console.WriteLine($"  {_results[0, 0]}  | {_results[0, 1]}  | {_results[0, 2]} ");
        Console.WriteLine($" --- --- ---");
        Console.WriteLine($"  {_results[1, 0]}  | {_results[1, 1]}  | {_results[1, 2]} ");
        Console.WriteLine($" --- --- ---");
        Console.WriteLine($"  {_results[2, 0]}  | {_results[2, 1]}  | {_results[2, 2]} ");
    }

    public void CheckPosition(Player p)
    {
        char isEmpty = '\0';
        bool isDone = false;


        while (!isDone)
        {
            Console.Write("Please choose a new square as [row,col] ");
            string? input = Console.ReadLine();
            string[] tmp_array = input.Split(',');
            int[] ints = tmp_array.Select(int.Parse).ToArray();
            isDone = false;

            if (_results[ints[0], ints[1]] == isEmpty)
            {
                _results[ints[0], ints[1]] = p._symbol;
                isDone = true;
            }
            else
            {
                Console.WriteLine("Square is already taken");
            }
        }
    }

    public void CreateSymbol(Player p)
    {
        Console.WriteLine($"Hello Player: {p._name}");
        _results[0, 1] = p._symbol;
    }
}

