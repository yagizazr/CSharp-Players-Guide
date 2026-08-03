

int correctNumber;

do
{
    Console.Write("Player 1, please enter a number between 0 and 100: ");
    correctNumber = Convert.ToInt32(Console.ReadLine());
} 
while (correctNumber < 0 || correctNumber > 100);

Console.Clear();

Console.WriteLine("Player 2, guess the number.");

while(true)
{
    
    Console.Write("What is your next guess? ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess < correctNumber) Console.WriteLine($"{guess} is too low.");
    else if (guess > correctNumber) Console.WriteLine($"{guess} is too high.");
    else break;

}

Console.WriteLine("You guessed the number!");