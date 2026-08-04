

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -809, 45, 90 };
int smallest = int.MaxValue;
int total = 0;
float average = 0;

foreach (int number in array)
{
    if (number < smallest)
        smallest = number;

    total += number;
}

average = (float)total / array.Length;

Console.WriteLine(smallest);
Console.WriteLine(average);