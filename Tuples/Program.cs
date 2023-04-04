// See https://aka.ms/new-console-template for more information

(Type, MainIngredient, Seasoning) food = (Type.Soup, MainIngredient.Potatoes, Seasoning.Spicy);

ChooseFood();

void ChooseFood()
{
    Console.WriteLine("Please choose a Type of Food: ");
    ChooseType();
    Console.WriteLine("Please choose Main Ingredient: ");
    ChooseMain();
    Console.WriteLine("Please choose Seasoning: ");
    ChooseSeasoning();

    Console.WriteLine($"Your choice: {food.Item1} with {food.Item2} and {food.Item3}");
}

void ChooseType()
{
    foreach(var item in Enum.GetValues(typeof(Type)))
    {
        Console.WriteLine(item);
    }

    string optionType = Console.ReadLine().ToLower();

    switch(optionType)
    {
        case "soup":
            food.Item1 = Type.Soup;
            break;
        case "stew":
            food.Item1 = Type.Stew;
            break;
        case "gumbo":
            food.Item1 = Type.Gumbo;
            break;
        default:
            break;
    }
}

void ChooseMain()
{
    foreach (var item in Enum.GetValues(typeof(MainIngredient)))
    {
        Console.WriteLine(item);
    }

    string optionType = Console.ReadLine().ToLower();

    switch (optionType)
    {
        case "mushrooms":
            food.Item2 = MainIngredient.Mushrooms;
            break;
        case "chicken":
            food.Item2 = MainIngredient.Chicken;
            break;
        case "carrots":
            food.Item2 = MainIngredient.Carrots;
            break;
        case "potatoes":
            food.Item2 = MainIngredient.Potatoes;
            break;
        default:
            break;
    }
}

void ChooseSeasoning()
{
    foreach (var item in Enum.GetValues(typeof(Seasoning)))
    {
        Console.WriteLine(item);
    }

    string optionType = Console.ReadLine().ToLower();

    switch (optionType)
    {
        case "spicy":
            food.Item3 = Seasoning.Spicy;
            break;
        case "salty":
            food.Item3 = Seasoning.Salty;
            break;
        case "sweet":
            food.Item3 = Seasoning.Sweet;
            break;
        default:
            break;
    }
}



enum Type
{
    Soup,
    Stew,
    Gumbo
}

enum MainIngredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}

