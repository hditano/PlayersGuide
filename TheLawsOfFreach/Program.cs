// See https://aka.ms/new-console-template for more information
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.

foreach(int item in array)
{
    if (item < currentSmallest)
        currentSmallest = item;
}

Console.WriteLine(currentSmallest);