// See https://aka.ms/new-console-template for more information

new Test().CallingIt();

public struct Coordinate
{
    public readonly int _row { get; }
    public readonly int _col { get; }
    
    public Coordinate(int row, int col)
    {
        _row = row;
        _col = col;
    }

    public string CheckStats(int row, int col)
    {
        if (row + 1 == col || col + 1 == row || row - 1 == col || col - 1 == row) return "Its next to each other";
        else return "It's not next to each other";
    }

}

class Test
{
    public void CallingIt()
    {
        Coordinate cord = new Coordinate();
        Console.WriteLine(cord.CheckStats(1, 3));
    }
}
