// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

double number = 10.0;

Console.WriteLine(number.NextDouble());

string[] MyList = { "up", "down", "left", "right" };
Console.WriteLine(RandomExtensions.NextString(MyList));

Console.WriteLine(RandomExtensions.CoinFlip(true));


public static class RandomExtensions
{
    public static double NextDouble(this double number)
    {
        double result = 0.0;

        if(number > result)
        {
            result = number;
        }

        return result;
        
    }

    public static string NextString(params string[] text)
    {
        string result = "";
        Random rnd = new Random();
        int Length = rnd.Next(text.Count());
        result = text[Length];
        return result;
    }

    public static bool CoinFlip(this bool coinFlip)
    {
        bool result = false;
        result = coinFlip ? coinFlip : !coinFlip;
        return result;
    }
}



