


Console.WriteLine("Please enter the base of the triangle: ");
float baseLength = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Please enter the height of the triangle: ");
float height = Convert.ToSingle(Console.ReadLine());

float area = (baseLength * height) / 2;
Console.WriteLine("The area of the triangle is: " + area);


Console.ReadKey();