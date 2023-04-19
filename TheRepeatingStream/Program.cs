// See https://aka.ms/new-console-template for more information
RecentNumbers recent = new RecentNumbers();
Thread thread = new Thread(recent.Run);

thread.Start();

recent.Run();

thread.Join();

Console.WriteLine($"Main Thread: {recent._number1} {recent._number2}");

public class RecentNumbers
{
    private object _numberGenerated = new object();
    public Random rand = new Random();
    public int _number1;
    public int _number2;

    public void Run()
    {
        _number1 = rand.Next(10);
        Console.WriteLine($"Number 1: {_number1}");
        _numberGenerated = _number1;
        Thread.Sleep(2000);
        _number2 = rand.Next(10);
        Console.WriteLine($"Number 2: {_number2}");
        Thread.Sleep(2000);
    }
}
