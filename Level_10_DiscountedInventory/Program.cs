

Console.WriteLine("Over here, stranger.");
Console.WriteLine("The following items are available:");
Console.WriteLine("1 – Rope");
Console.WriteLine("2 – Torches");
Console.WriteLine("3 – Climbing Equipment");
Console.WriteLine("4 – Clean Water");
Console.WriteLine("5 – Machete");
Console.WriteLine("6 – Canoe");
Console.WriteLine("7 – Food Supplies");

Console.Write("What number do you want to see the price of? ");
int itemNumber = Convert.ToInt32(Console.ReadLine());

if (itemNumber < 1 || itemNumber > 7)
{
    Console.WriteLine("Please enter a valid item number.");
    return;
}

string itemName = itemNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Nothing"
};

float price = itemNumber switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0
};

Console.Write("And what was your name again stranger? ");
string customerName = Console.ReadLine();

if (customerName == "Leon Kennedy")
{
    Console.WriteLine("Got a selection of good things on sale, stranger!");
    price /= 2;
}

Console.WriteLine($"{itemName} costs {price} gold.");
Console.WriteLine("Come back any time.");

Console.ReadKey();