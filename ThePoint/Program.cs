// See https://aka.ms/new-console-template for more information

Point newPoint = new Point(2, 3);
Point newPoint1 = new Point(-4, 0);
newPoint.RenderPoint();
newPoint1.RenderPoint();

class Point
{
    private int _pointX;
    private int _pointY;

    public Point(int X, int Y)
    {
        this._pointX = X;
        this._pointY = Y;
    }

    public int PointX
    {
        get => _pointX;
        set => _pointX = value;
    }

    public int PointY
    {
        get => _pointY;
        set => _pointY = value;
    }

    public static Point DefaultPoint() => new Point(0, 0);

    public void RenderPoint()
    {
        Console.WriteLine($"X: {this._pointX} Y: {this._pointY}");
    }
}
