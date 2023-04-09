// See https://aka.ms/new-console-template for more information

new Pack().Add();

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
    private InventoryItem[] array { get; set; } = { new Sword(), new Food(), new Water(), new Rope(), new Bow(), new Arrow() };
    private double MaxWeight { get;} = 5;
    private double MaxVolume { get; } = 5;

    public void Add()
    {

        foreach(var i in array)
        {
            if (MaxWeight > i._weight || MaxVolume > i._volume)
            {
                Console.WriteLine($"Item about to be added: {i}");
                array[array.Length - 1] = i;
            }
            else
            {
                Console.WriteLine($"Item could not been added {i}");
            }
        }

    }

}