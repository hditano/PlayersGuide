// See https://aka.ms/new-console-template for more information

MainLoop.Run();

public class MainLoop
{
    public static void Run()
    {
        State state = new State();
        state.States();
        
    }
}


public class Grid : StateProps
{
    private int[,] _MyGrid { get; set; }


    public Grid()
    {
        _MyGrid = new int[4, 4];
    }

    public void Display()
    {
        for(var i = 0; i < _MyGrid.GetLength(0); i++)
        {
            for(var j = 0; j < _MyGrid.GetLength(1); j++)
            {
                Console.Write($"{_MyGrid[i, j]}");
            }
        }
    }

}

public class State : StateProps
{

    private Grid MyGrid { get; }

    public State()
    {
        MyGrid = new Grid();
    }

    public void States()
    {
        while(!(_ActivateFountain && _FinishedGame))
        {

            CheckPlayerPosition();

        }

        Console.WriteLine("You did it!!");
        Console.Write($"It took you to finish {DateTime.Now - _StartTime}");
        Console.ReadLine();
    }

    public void CheckPlayerPosition()
    {
        Console.WriteLine("What do you want to do?: ");
        string? reply = Console.ReadLine();

        switch(reply)
        {
            case "move north": 
                var newLocation = new Location(_PlayerLocation.row - 1, _PlayerLocation.col);
                if(IsOnMap(newLocation)) 
                    _PlayerLocation = newLocation; break;
            case "move south": 
                var newLocation1 = new Location(_PlayerLocation.row + 1, _PlayerLocation.col);
                if(IsOnMap(newLocation1)) 
                    _PlayerLocation = newLocation1;  break;
            case "move east":  
                var newLocation2 = new Location(_PlayerLocation.row, _PlayerLocation.col + 1);
                if (IsOnMap(newLocation2))
                    _PlayerLocation = newLocation2;  break;
            case "move west": 
                var newLocation3 = new Location(_PlayerLocation.row, _PlayerLocation.col - 1);
                if(IsOnMap(newLocation3))
                    _PlayerLocation = newLocation3;  break;
            case "enable":
                if (IsOverFountain())
                    Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated"); 
                    _ActivateFountain = true; break;
            case "exit":
                if (IsFinished())
                    Console.WriteLine("The Fountain of Objects has been reactivated and you have escaped with your life");
                    _FinishedGame = true; break;
            default:break;
        }

        Console.WriteLine($" Player: {_PlayerLocation}");
        Console.WriteLine($"Fountain: {_FountainOfObjects}");
    }

    public bool IsOnMap(Location location) => location.row >= 0 && location.row <= 4 && location.col >= 0 && location.col <= 4;
    public bool IsOverFountain() => _PlayerLocation.row == _FountainOfObjects.row && _PlayerLocation.col == _FountainOfObjects.col;
    public bool IsFinished() => _PlayerLocation.row == _ExitLocation.row && _PlayerLocation.col == _ExitLocation.row; 
    
}


public class StateProps
{
    protected Location _FountainOfObjects { get; }
    protected Location _PlayerLocation { get; set; }
    protected Location _ExitLocation { get; set; }
    protected bool _ActivateFountain { get; set; }
    protected bool _FinishedGame { get; set; }
    protected DateTime _StartTime { get; }
    protected TimeSpan _TimeLeft { get; set; }


    public StateProps()
    {
        _FountainOfObjects = new Location(0, 2);
        _PlayerLocation = new Location(0, 0);
        _ExitLocation = new Location(0, 0);
        _ActivateFountain = false;
        _FinishedGame = false;
        _StartTime = DateTime.Now;

    }
}


public record Location(int row, int col);


public enum Rooms { Fountain, Player }