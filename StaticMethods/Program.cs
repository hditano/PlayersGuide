// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Arrow myArrow = new Arrow(ArrowHead.steel, Fletching.plastic, 300);
myArrow.GetCost();

Console.WriteLine(Arrow.CreateEliteArrow());

class Arrow
{
    private ArrowHead arrowhead;
    private Fletching fletching;
    private float length;
    private float cost;

    public static Arrow CreateEliteArrow() => new Arrow(ArrowHead.steel, Fletching.plastic, 95);
    public static Arrow BeginnerArrow() => new Arrow(ArrowHead.wood, Fletching.goose, 75);
    public static Arrow MarksmanArrow() => new Arrow(ArrowHead.steel, Fletching.goose, 65);

    public Arrow(ArrowHead arrowhead, Fletching fletching, float length)
    {
        this.arrowhead = arrowhead;
        this.fletching = fletching;
        this.length = length;
    }

    public ArrowHead ArrowHead
    {
        get => this.arrowhead;
        set => this.arrowhead = value;
    }

    public Fletching Fletching
    {
        get => this.fletching;
        set => this.fletching = value;
    }

    public float Length
    {
        get => this.length;
        set => this.length = value;
    }


    public void GetCost()
    {
        Console.WriteLine($"Cost of the following combination is: {this.arrowhead} {this.fletching} {this.length}");
        CalculateCost();
        Console.WriteLine($"Total cost is: {this.cost}");
    }

    public void CalculateCost()
    {

        switch (this.arrowhead)
        {
            case ArrowHead.wood:
                this.cost += 3;
                break;
            case ArrowHead.steel:
                this.cost += 10;
                break;
            case ArrowHead.obsidian:
                this.cost += 5;
                break;
            default:
                break;
        }

        switch (this.fletching)
        {
            case Fletching.turkey:
                this.cost += 5;
                break;
            case Fletching.plastic:
                this.cost += 5;
                break;
            case Fletching.goose:
                this.cost += 3;
                break;
            default:
                break;
        }

        Console.Write("Please Choose a Length: ");
        float tmpLength = (float)Convert.ToDouble(Console.ReadLine());
        this.length += (float)(tmpLength * 0.5);
        this.cost += this.length;


    }
}



enum ArrowHead
{
    steel = 10,
    wood = 3,
    obsidian = 5
}

enum Fletching
{
    plastic = 10,
    turkey = 5,
    goose = 3
}