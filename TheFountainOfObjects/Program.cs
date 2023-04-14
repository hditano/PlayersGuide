// See https://aka.ms/new-console-template for more information

MainLoop.Start();

// The main grid class generates a grid based on the values of X and Y passed to it, and populates each array position with values ranging from 0 to XX for future reference.
public class Grid
{
    public int[,] _MyGrid;
    public int _X;
    public int _Y;
    private int _index = 0;

    public Grid(int x, int y)
    {
        _X = x;
        _Y = y;
        _MyGrid = new int[_X, _Y];
    }

    public void AddValuesToGrid()
    {
        for(var i = 0; i < _MyGrid.GetLength(0); i++)
        {
            for(var j = 0; j < _MyGrid.GetLength(1); j++)
            {
                _MyGrid[i, j] = _index;
                _index++;
            }
        }
    }

    public void Display()
    {
        for(var i = 0; i < _MyGrid.GetLength(0);i++)
        {
            for(var j = 0; j < _MyGrid.GetLength(1);j++)
            {
                int value = _MyGrid[i, j];
                int length = value.ToString().Length;
                if (length == 1) Console.Write($" {value} ");
                else Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }

}

// State managment class that inherits from Stateprops
public class State : StateProps
{

    public static void CheckPosition()
    {
        State state = new State();
        state._PlayerPosition = (0, 1);
    }
}

// abstract class that creates props
public abstract class StateProps
{
    protected bool _Fountain { get; set; }
    protected (int, int) _FountainPosition { get; }
    protected bool _EntranceExit { get; set; }
    protected (int, int) _EntranceExitPosition { get; }
    protected (int, int) _PlayerPosition { get; set; }

    public StateProps()
    {
        _Fountain = false;
        _FountainPosition = (0, 2);
        _EntranceExitPosition = (0, 0);
        _PlayerPosition = (0, 0);
    }

}

// Record to create Player class
public record Player(char Symbol);


// Main Game Loop
public class MainLoop
{
    public static void Start()
    {
        bool GameOver = false;
        Grid MyGame = new Grid(4, 4);
        MyGame.AddValuesToGrid();

        while(!GameOver)
        {
            MyGame.Display();
            State.CheckPosition();

            string? input = Console.ReadLine();

            Console.Clear();
        }
        

    }

}
