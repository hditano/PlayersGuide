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

    public string CheckStats()
    {
        if (_row + 1 == _col || _col + 1 == _row || _row - 1 == _col || _col - 1 == _row) return "Its next to each other";
        else return "It's not next to each other";
    }

}

class Test
{
    public void CallingIt()
    {
        Coordinate cord = new Coordinate(1,2);
        Console.WriteLine(cord.CheckStats());
    }
}
