// See https://aka.ms/new-console-template for more information

Sword mySword = new Sword(Material.wood ,Gemstone.sapphire, 10.2F, 23.1F);
Console.WriteLine(mySword.ToString());
Sword mySword2 = mySword with { Mat = Material.iron, Gem = Gemstone.None };
Console.WriteLine(mySword2.ToString());

public record Sword(Material Mat ,Gemstone? Gem, float Length, float Width);

public enum Gemstone
{
    emerald,
    amber,
    sapphire,
    diamond,
    bitstone,
    None
}

public enum Material
{
    wood,
    bronze,
    iron,
    steel,
    binarium
}
