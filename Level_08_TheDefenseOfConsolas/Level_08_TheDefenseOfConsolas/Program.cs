
// Window title
Console.Title = "The Defense of Consolas";

// Asking the user for the target row and column
Console.Write("Target Row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column: ");
int column = Convert.ToInt32(Console.ReadLine());

// Display colors
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Magenta;

// Deploying the squad

Console.WriteLine("Deploy to:");

Console.WriteLine($"({row}, {column - 1})");
Console.WriteLine($"({row - 1}, {column})");
Console.WriteLine($"({row}, {column + 1})");
Console.WriteLine($"({row + 1}, {column})");

// Playing a sound to indicate deployment
Console.Beep(523, 100); 
Console.Beep(659, 100); 
Console.Beep(784, 250);

Console.ReadKey();


    














