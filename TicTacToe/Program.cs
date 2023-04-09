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

        while (counter <= 9)
        {

            if (counter % 2 == 0)
            {
                counter++;
                new1.CheckPosition(player1, counter);
                if (new1.CheckState(player1))
                {
                    Console.WriteLine("Player 1 has won!"); 
                    break;
                }
                
                
            } else
            {
                counter++;
                new1.CheckPosition(player2, counter);
                if (new1.CheckState(player2))
                {
                    Console.WriteLine("Player 2 has won!"); 
                    break;
                }

            }
            new1.ShowBoard();
        }

    }
}


class Player
{
    internal string? _name { get; }
    internal char _symbol { get; }

    internal Player(string name, char symbol)
    {
        _name = name;
        _symbol = symbol;
    }
}

class Board
{
    private char[,] _results { get; set; } = new char[3, 3];

    public void ShowBoard()
    {
        Console.WriteLine("Tic Tac Toe");
        Console.WriteLine("-------------");
        Console.WriteLine("");
        Console.WriteLine($"  {_results[0, 0]}  | {_results[0, 1]} | {_results[0, 2]} ");
        Console.WriteLine($" ---+--+---");
        Console.WriteLine($"   {_results[1, 0]} | {_results[1, 1]} | {_results[1, 2]} ");
        Console.WriteLine($" ---+--+---");
        Console.WriteLine($"  {_results[2, 0]}  | {_results[2, 1]} | {_results[2, 2]} ");
    }

    public void CheckPosition(Player p, int counter)
    {
        char isEmpty = '\0';
        bool isDone = false;

        try
        {

            while (!isDone)
            {
                Console.WriteLine($"Round: {counter} | Player: {p._name}");
                Console.Write($"Please choose a new square as [row,col]: ");
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

        catch (Exception e)
        {
            Console.WriteLine($"Error Outflown: {e}");
        }
    }

    internal bool CheckState(Player p)
    {
        if (_results[0, 0] == p._symbol && _results[0, 1] == p._symbol && _results[0, 2] == p._symbol) return true;
        if (_results[1, 0] == p._symbol && _results[1, 1] == p._symbol && _results[1, 2] == p._symbol) return true;
        if (_results[2, 0] == p._symbol && _results[2, 1] == p._symbol && _results[2, 2] == p._symbol) return true;

        if (_results[0, 0] == p._symbol && _results[1, 0] == p._symbol && _results[2, 0] == p._symbol) return true;
        if (_results[1, 1] == p._symbol && _results[2, 1] == p._symbol && _results[3, 1] == p._symbol) return true;
        if (_results[0, 2] == p._symbol && _results[1, 2] == p._symbol && _results[2, 2] == p._symbol) return true;

        if (_results[0, 1] == p._symbol && _results[1, 1] == p._symbol && _results[2, 2] == p._symbol) return true;
        if (_results[0, 2] == p._symbol && _results[1, 1] == p._symbol && _results[2, 0] == p._symbol) return true;

        else return false;


    }


}


