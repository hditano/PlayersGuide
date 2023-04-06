// See https://aka.ms/new-console-template for more information

TheColor newColor = new TheColor(24, 200, 34);
newColor.RenderColor();

TheColor yellow = TheColor.Yellow();
Console.WriteLine($"Color value of Yellow are: R: {yellow.R} G: {yellow.G} B: {yellow.B}");

class TheColor
{
    private int _R;
    private int _G;
    private int _B;

    public TheColor(int r, int g, int b)
    {
        this._R = r;
        this._G = g;
        this._B = b;
    }

    public int R
    {
        get => this._R;
        set => this._R = value;
    }

    public int G
    {
        get => this._G;
        set => this._G = value;
    }

    public int B
    {
        get => this._B;
        set => this._B = value;
    }

    public static TheColor White() => new TheColor(255, 255, 255);
    public static TheColor Black() => new TheColor(0, 0, 0);
    public static TheColor Red() => new TheColor(255, 0, 0);
    public static TheColor Orange() => new TheColor(255, 165, 0);
    public static TheColor Yellow() => new TheColor(255, 255, 0);
    public static TheColor Green() => new TheColor(0, 128, 0);
    public static TheColor Blue() => new TheColor(0, 0, 255);
    public static TheColor Purple() => new TheColor(128, 0, 128);

    public void RenderColor()
    {
        Console.WriteLine($"Color Values are: R: {this._R} G: {this._G} B: {this._B} ");
    }

}
