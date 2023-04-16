// See https://aka.ms/new-console-template for more information

using System.Net;

Sieve MyDelegate = new Sieve();
MyDelegate._func3(20);

public class Sieve
{
    public Func<int, bool> _func;
    public Func<int, bool> _func2;
    public Func<int, bool> _func3;


    public Sieve()
    {
        _func = IsEven;
        _func2 = IsPositive;
        _func3 = IsMultiple;
    }

    private bool IsGood(int number)
    {
        if (number > 0) return true;
        else return false;
    }

    private bool IsEven(int number)
    {
        return number % 2 == 0 ? true : false;
    }

    private bool IsPositive(int number)
    {
        return number > 0 ? true : false;
    }

    private bool IsMultiple(int number)
    {
        return number % 10 == 0 ? true : false;
    }
}
