// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

Player p1 = new Player("Hernan");
Player p2 = new Player("Zoe");


GameManager Start = new GameManager();
Start.Display(p1);
Start.Display(p2);
Start.Calculate();


public class GameManager
{
    private int RandomNumber { get; set; }
    private int Player1Number { get; set; }
    private int Player2Number { get; set; }

    public GameManager()
    {
        this.RandomNumber = new Random().Next(9) + 1;
    }

    public void Display(Player p)
    {

        Console.WriteLine(this.RandomNumber.ToString());
        Console.WriteLine($"Hello {p.Name}, please choose a number: ");
        string? response = Console.ReadLine();
        if (p.Name == "Hernan") this.Player1Number = int.Parse(response);
        else this.Player2Number = int.Parse(response);

        Console.WriteLine($"Numbers: p1 {this.Player1Number} p2: {this.Player2Number}");

    }

    public void Calculate()
    {
        if (this.Player1Number == this.RandomNumber || this.Player2Number == this.RandomNumber) throw new Exception("Number matches");
    }

}

public class Player
{
    public string Name { get; set; }
    public int Number { get; set; }

    public Player(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return $"{this.Name}";
    }
}
