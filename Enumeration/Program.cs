// See https://aka.ms/new-console-template for more information


States current = States.Locked;

    while (true)
    {
        Console.Write($"The chest is {current}. What do you want to do?: ");
        string reply = Console.ReadLine();
        if (current == States.Locked && reply == "unlock")
        {
            current = States.Closed;
        }
        if (current == States.Closed && reply == "open")
        {
            current = States.Open;
        }
        if (current == States.Open && reply == "close")
        {
            current = States.Closed;
        }
        if (current == States.Closed && reply == "lock")
        {
            current = States.Locked;
        } 

    }


enum States {
    Open,
    Closed,
    Locked,
}

