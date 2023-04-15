// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please type in a number: ");
string value = Console.ReadLine();

int.TryParse(value, out int result);
Console.WriteLine(result);


