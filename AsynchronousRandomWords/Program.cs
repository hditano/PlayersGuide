// See https://aka.ms/new-console-template for more information

Console.WriteLine(RandomlyRecreate("he"));

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
