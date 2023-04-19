// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please type in a word: ");
string reply = Console.ReadLine();

DateTime start = DateTime.Now;
int result = await RandomlyRecreateAsync(reply);
TimeSpan timeDiff = DateTime.Now - start;
Console.WriteLine($"Total time was {timeDiff.TotalMilliseconds / 1000} seconds");

int RandomlyRecreate(string word)
{
    int result = 0;
    Random rand = new Random();
    string tmpWord;

    do
    {
        tmpWord = "";
        result++;
        for (int index = 0; index < word.Length; index++)
        {
            tmpWord += (char)('a' + rand.Next(26));
            Console.WriteLine(tmpWord);
        }
    } while (tmpWord != word);

    return result;
    
}

Task<int> RandomlyRecreateAsync(string word)
{
    return Task.Run(() =>
    {
        return RandomlyRecreate(word);
    });

}

