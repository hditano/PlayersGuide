// See https://aka.ms/new-console-template for more information

Console.WriteLine(AskForNumber("Whats your age: "));

int AskForNumber(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt16(Console.ReadLine());
    return result;
    
}


Console.WriteLine(AskForNumberInRange("Type a Number", 10, 30));

int AskForNumberInRange(string text, int min, int max)
{
    int num;
    do
    {
        Console.WriteLine(text);
        num = Convert.ToInt32(Console.ReadLine());

    } while (num < min || num > max);

    return num;
}


Console.WriteLine(countDown(20));
int countDown(int a)
{
    if (a == 0)
    {
        return 0;
    } else
    {
        Console.WriteLine(a);
        return countDown(a - 1);
    }
}
