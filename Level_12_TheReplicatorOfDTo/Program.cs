

int[] original = new int[5];
Console.WriteLine("Please enter five numbers.");

for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    original[i] = Convert.ToInt32(Console.ReadLine());
}

int[] copy = new int[5];

for (int i = 0 ; i < 5; i++)
{
    copy[i] = original[i];
}

for (int i = 0 ; i < 5; i++)
{
    Console.WriteLine($"{original[i]} to {copy[i]}");
}

