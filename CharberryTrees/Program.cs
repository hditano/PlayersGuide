// See https://aka.ms/new-console-template for more information


CharberryTree tree = new CharberryTree();
Notifier not = new Notifier(tree);

while (true)
    tree.MaybeGrow();


public class CharberryTree
{
    private Random _random = new Random();
    public bool Ripe { get; set; }
    public event Action? Ripped;

    public void MaybeGrow()
    {
        // Only a tiny chance of ripening each time, but we try a lot!
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
            Ripped?.Invoke();
        }
    }
}

public class Notifier
{
    public Notifier(CharberryTree tree)
    {
        tree.Ripped += OnRippened;
    }

    private void OnRippened()
    {
        Console.WriteLine("Charberry fruit has been rippened");
    }
}