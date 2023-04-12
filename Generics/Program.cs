// See https://aka.ms/new-console-template for more information

ColoredItem<Sword> coloredSword = new ColoredItem<Sword>(ConsoleColor.DarkBlue, new Sword());
coloredSword.Display();

public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredItem<T>
{
    ConsoleColor _CColor { get; set; }
    T _Item { get; set; }

    public ColoredItem(ConsoleColor ccolor, T item)
    {
        _CColor = ccolor;
        _Item = item;
    }

    public void Display()
    {
        Console.ForegroundColor = _CColor;
        Console.WriteLine(_Item);
    }
}
