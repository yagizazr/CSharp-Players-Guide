

Console.Write("Please enter a x value: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter a y value: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x < 0) {

    if (y > 0)
    {
        Console.WriteLine("The enemy is to the northwest!");
    }

    if (y == 0)
    {
        Console.WriteLine("The enemy is to the west!");
    }

    if (y < 0)
    {
        Console.WriteLine("The enemy is to the southwest!");
    }

}

else if (x == 0) {
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the north!");
    }
    if (y == 0)
    {
        Console.WriteLine("The enemy is here!");
    }
    if (y < 0)
    {
        Console.WriteLine("The enemy is to the south!");
    }
}

else {
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the northeast!");
    }
    if (y == 0)
    {
        Console.WriteLine("The enemy is to the east!");
    }
    if (y < 0)
    {
        Console.WriteLine("The enemy is to the southeast!");
    }
}

Console.ReadKey();
