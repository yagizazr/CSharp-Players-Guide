States current = States.locked;

while (true)
{
    Console.Write($"The chest is {current}. What do you want to do ");
    string text = Console.ReadLine();

    if (current == States.locked && text == "unlock")
    {
        current = States.closed;
    }

    else if (current == States.closed && text == "lock")
    {
        current = States.locked;
    }

    else if (current == States.closed && text == "open")
    {
        current = States.open;
    }

    else if (current == States.open && text == "close")
    {
        current = States.closed;
    }

}
enum States { locked, closed, open }