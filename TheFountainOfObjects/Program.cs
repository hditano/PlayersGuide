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
    }

}

public class State : StateProps
{

    public void States()
    {
        while(!(_OnFountain && _OnExit))
        {

            if (IsOverFountain())
            {
                _OnFountain = true;
            }
            if (IsFinished())
            {
                _OnExit = true;
            }

            CheckPlayerPosition();

        }

        Console.WriteLine("You did it!!");
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
            default:break;
        }

        Console.WriteLine($" Player: {_PlayerLocation}");
        Console.WriteLine($"Fountain: {_FountainOfObjects}");
        Console.WriteLine($"Fountain bool: {_OnFountain}");
        Console.WriteLine($"Exit bool: {_OnExit}");
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
    protected bool _OnFountain { get; set; }
    protected bool _OnExit { get; set; }

    public StateProps()
    {
        _FountainOfObjects = new Location(0, 2);
        _PlayerLocation = new Location(0, 0);
        _ExitLocation = new Location(0, 0);
        _OnFountain = false;
        _OnExit = false;

    }
}


public record Location(int row, int col);


public enum Rooms { Fountain, Player }