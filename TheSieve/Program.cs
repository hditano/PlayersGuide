// See https://aka.ms/new-console-template for more information

Console.Write("Please choose a filter: 1.IsEven 2.IsPositive 3.IsMultiple10: ");
int reply = Convert.ToInt32(Console.ReadLine());

Sieve sieve = reply switch
{
    1 => new Sieve(IsEven),
    2 => new Sieve(IsPositive),
    3 => new Sieve(IsMultiple10),
    _ => throw new NotImplementedException(),
};


while(true)
{
    Console.WriteLine("Write a Number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    string goodOrEvil = sieve.IsGoodMethod(number) ? "good" : "false";
    Console.WriteLine($"{number} is {goodOrEvil}");
}

bool IsEven(int num) => num % 2 == 0;
bool IsPositive(int num) => num > 0;
bool IsMultiple10(int num) => num % 10 == 0;

public class Sieve
{
    public delegate bool IsGoodDelegate(int number);

    public IsGoodDelegate isGood;

    public Sieve(IsGoodDelegate operation)
    {
        isGood = operation;
    }

    public bool IsGoodMethod(int number)
    {
        return isGood(number);
    }
}