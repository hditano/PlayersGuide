// See https://aka.ms/new-console-template for more information

int THE_MANTICORE = 10;
int CITY = 15;
int ROUND = 1;
string DISTANCE = "";

Console.WriteLine("Player 1 it is your turn. ");
Console.WriteLine("-----------------------------------");
Console.Write("How far from the city do you want to station the Manticore: ");
DISTANCE = Console.ReadLine();
Console.Clear();

while (THE_MANTICORE > 0 || CITY > 0)
{
    Console.WriteLine($"STATUS: Round: {ROUND}  City: {CITY}/15  Manticore: {THE_MANTICORE}/10");
    int modifier = ComputeModifier(ROUND);
    Console.WriteLine($"The cannon is expected to deal {modifier} damage this round");
    Console.Write("Enter desired cannon range: ");
    int range = Convert.ToInt32(Console.ReadLine());
    string damageText = ComputeDamage(range);
    Console.WriteLine($"That round was a {damageText}");
    string result = ComputeResult(modifier);
    Console.WriteLine($"{result}");

    if (THE_MANTICORE <= 0) break;

}


int ComputeModifier(int modifier)
{
    if (modifier % 3 == 0 && modifier % 5 == 0) return 10;
    if (modifier % 3 == 0 || modifier % 5 == 0) return 3;
    else return 1;
}

string ComputeDamage(int modifier)
{
    if (Convert.ToInt32(DISTANCE) == modifier) return "DIRECT HIT";
    if (Convert.ToInt32(DISTANCE) < modifier) return "OVERSHOT";
    else return "FELL SHORT";
}

string ComputeResult(int modifier)
{
    if (THE_MANTICORE > 0)
    {
        CITY--;
        ROUND++;
        THE_MANTICORE -= modifier;
        return "--------------------------------";
    } else
    {
        return $"The Manticore has been destroyed! The city of Consolas has been saved!";
    }
}