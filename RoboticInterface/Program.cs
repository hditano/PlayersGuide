// See https://aka.ms/new-console-template for more information

Robot robot = new Robot();
robot.Commands[0] = new OnCommand();
robot.Commands[1] = new WestCommand();
robot.Commands[2] = new EastCommand();
robot.Run();


public interface IRobotCommand
{
    public void Run(Robot robot);
}

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
    public virtual void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public class SouthCommand : IRobotCommand
{
    public  void Run(Robot robot)
    {
        robot.X -= 1;
    }
}

public class NorthCommand : IRobotCommand
{
    public  void Run(Robot robot)
    {
        robot.X += 1;
    }
}

public class EastCommand : IRobotCommand
{
    public  void Run(Robot robot)
    {
        robot.Y -= 1;
    }
}

public class WestCommand : IRobotCommand
{
    public  void Run(Robot robot)
    {
        robot.Y += 1;
    }
}

public class OnCommand : IRobotCommand
{
    public  void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommand
{
    public  void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}
