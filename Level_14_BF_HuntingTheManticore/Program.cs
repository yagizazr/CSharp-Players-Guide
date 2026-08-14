int distance = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
int manticore = 10;
int city = 15;
int round = 1;
int damage;

Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

while (true)
{
    if (manticore <= 0 || city <= 0) break;

    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round}  City: {city}/15  Manticore: {manticore}/10");
    if (round % 15 == 0) 
    {
        damage = 10;
        Console.WriteLine("The cannon is expected to deal 10 damage this round.");
    }
    else if (round % 3 == 0 || round % 5 == 0)
    {
        damage = 3;
        Console.WriteLine("The cannon is expected to deal 3 damage this round.");
    }
    else 
    {
        damage = 1;
        Console.WriteLine("The cannon is expected to deal 1 damage this round.");
    }

    Console.Write("Enter desired cannon range: ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess > distance) Console.WriteLine("That round OVERSHOT the target.");
    else if (guess < distance) Console.WriteLine("That round FELL SHORT of the target.");
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        manticore -= damage;
    }

    round++;
    city--;
}

if (manticore <= 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The Manticore has been destroyed. The city of Consolas wins.");
}
else if (city <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The city of Consolas has been destroyed. The Manticore wins.");
}
Console.ResetColor();

int AskForNumber(string text)
{
    Console.Write(text + " ");
    distance = Convert.ToInt32(Console.ReadLine());
    return distance;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        distance = AskForNumber(text);
        if (distance >= min && distance <= max)
        {
            return distance;
        }
    }
}