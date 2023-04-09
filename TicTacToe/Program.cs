// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

new TicTacToe().Run();

class TicTacToe
{

    private Player player1 { get; } = new Player("Hernan", 'X');
    private Player player2 { get; } = new Player("Zoe", 'O');
    private int counter { get; set; } = 0;

    public void Run()
    {
        
        Board new1 = new Board();

        while (counter !< 9)
        {
            if (counter % 2 == 0)
            {
                counter++;
                new1.CheckPosition(player1, counter);
                
            }
            else
            {
                counter++;
                new1.CheckPosition(player2, counter);
            }

            new1.ShowBoard();

        }

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
    private State _state { get; set; } = new State();

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

    public void CheckPosition(Player p, int counter)
    {
        char isEmpty = '\0';
        bool isDone = false;

        Console.WriteLine(_state.CheckState(_results, p));

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
}

class State
{

    internal bool CheckState(char[,] results, Player p)
    {
        if (results[0, 0] == p._symbol && results[0, 1] == p._symbol && results[0, 2] == p._symbol) return true;
        if (results[1,0] == p._symbol && results[1,1] == p._symbol && results[1,2] == p._symbol) return true;
        if (results[2,0] == p._symbol && results[2,1] == p._symbol && results[2,2] == p._symbol) return true;

        if (results[0,0] == p._symbol && results[1,0] == p._symbol && results[2,0] == p._symbol) return true;
        if (results[1,1] == p._symbol && results[2,1] == p._symbol && results[3,1] == p._symbol) return true;
        if (results[0,2] == p._symbol && results[1,2] == p._symbol && results[2,2] == p._symbol) return true;

        if (results[0, 1] == p._symbol && results[1, 1] == p._symbol && results[2, 2] == p._symbol) return true;
        if (results[0, 2] == p._symbol && results[1, 1] == p._symbol && results[2, 0] == p._symbol) return true;

        else return false;


    }

}

