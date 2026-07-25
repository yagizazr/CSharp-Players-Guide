

Console.Title = "The Defense of Consolas";

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Magenta;

Console.Write("Target Row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy to:");

Console.WriteLine($"({row}, {column - 1})");
Console.WriteLine($"({row - 1}, {column})");
Console.WriteLine($"({row}, {column + 1})");
Console.WriteLine($"({row + 1}, {column})");

Task.Run(() => Console.Beep(37, 3000));

// Kartın uyanması için yarım saniye bekleyin
System.Threading.Thread.Sleep(500);

// Artık 1 saniyelik veya yarım saniyelik kısa sesleriniz ANINDA çalacaktır

Console.Beep(523, 100); 
Console.Beep(659, 100); 
Console.Beep(784, 250);

Console.ReadKey();


    














