// See https://aka.ms/new-console-template for more information

using System.Reflection.PortableExecutable;

int[] myArray = new int[5];

Console.WriteLine("Please type in 5 values: ");
Console.WriteLine(myArray.Length);

for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine("Please type a value: ");
    string myTemp = Console.ReadLine();
    myArray[i] = Int32.Parse(myTemp);
}

int[] secondArray = new int[5];

for(int i = 0; i < secondArray.Length; i++)
{
    secondArray[i] = myArray[i];
}

for(int i = 0; i< secondArray.Length;i++)
{
    Console.WriteLine($"My first array has the following values: {myArray[i]}");
    Console.WriteLine($"My second array has the following values: {secondArray[i]}");
}
