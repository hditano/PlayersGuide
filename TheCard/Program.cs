// See https://aka.ms/new-console-template for more information

Card c1 = new Card(Colors.red, Rank.five);
bool isNumberCard = c1.IsCardNumber();
Console.WriteLine(isNumberCard);

Card.NewCard();

class Card
{
    private readonly Colors _color;
    private readonly Rank _rank;
    private bool _IsCardNumber;
    private bool _IsColor;

    public Card(Colors color, Rank rank)
    {
        this._color = color;
        this._rank = rank;

    }

    public Colors NewColor
    {
        get => this._color;
    }

    public Rank NewRank
    {
        get => this._rank;
    }

    public bool IsCardNumber()
    {
        return this.NewRank >= Rank.one && NewRank <= Rank.ten;
    }

    public bool IsSymbolCard()
    {
        return !IsCardNumber();
    }


    public static string NewCard()
    {
        foreach (string item in Enum.GetNames(typeof(Rank)))
        {
            foreach(string jtem in Enum.GetNames(typeof(Colors)))
            {
                Console.WriteLine($" The {jtem} {item}");
            }
        }
        return ""; 
    }

    

}

enum Colors
{
    red,
    green,
    blue,
    yellow
}

enum Rank
{
    one,
    two,
    three,
    four,
    five,
    six,
    seven,
    eight,
    nine,
    ten,
    dollarSign,
    percentage,
    carat,
    ampersand

}
