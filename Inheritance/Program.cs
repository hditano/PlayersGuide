// See https://aka.ms/new-console-template for more information

new Pack().Add(new Arrow());

class InventoryItem
{
    public double _weight { get; set; }
    public double _volume { get; set; }


    public InventoryItem(double weight, double volume)
    {
        _weight = weight;
        _volume = volume;
    }


}

class Arrow : InventoryItem
{

    public Arrow() : base(0.1, 0.05) { }

}

class Bow : InventoryItem
{
    public Bow() : base(1, 4) { }

}

class Rope : InventoryItem
{
    public Rope () : base (1, 1.5) { }
}

class Water : InventoryItem
{
    public Water() : base(2, 3) { }
}

class Food : InventoryItem
{
    public Food() : base(1, 0.5) { }

}

class Sword : InventoryItem
{
    public Sword() : base(5, 3) { }

}


class Pack
{
    private InventoryItem[] array { get; set; } = new InventoryItem[10];
    private int TotalItems { get;} = 10;
    private double MaxWeight { get;} = 3;
    private double MaxVolume { get; } = 3;

    public bool Add(InventoryItem item)
    {
        if (MaxWeight > item._weight || MaxVolume > item._volume)
        {
            array[array.Length - 1] = item;
            Console.WriteLine("Item added");
            return true;
        } else
        {
            return false;
        }
    }

}