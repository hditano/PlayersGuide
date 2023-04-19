// See https://aka.ms/new-console-template for more information
RecentNumbers recent = new RecentNumbers();
Thread thread = new Thread(recent.Run);

thread.Start();


thread.Join();

Console.WriteLine($"Main Thread: {recent.Number1} {recent.Number2}");

public class RecentNumbers
{
    private object _numberGenerated = new object();
    public Random _rand;
    public int _number1;
    public int _number2;
    
    public RecentNumbers()
    {
        _rand = new Random();
    }

    public int Number1
    {
        get
        {
            lock (_numberGenerated)
            {
                return _number1;
            }
        }
    }

    public int Number2
    {
        get
        {
            lock(_numberGenerated)
            {
                return _number2;
            }
        }
    }


    public void Run()
    {
        _number1 = _rand.Next(10);
        Console.WriteLine($"Number 1: {_number1} Number 2: {_number2}");
        Thread.Sleep(2000);
        _number2 = _rand.Next(10);
        Console.WriteLine($"Number 2: {_number2} Number 1: {_number1}");
        Thread.Sleep(2000);
    }
}
