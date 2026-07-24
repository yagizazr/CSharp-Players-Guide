
Console.Write("Please enter the gathered chocolate egg amount today: ");
int gatheredEggs = Convert.ToInt32(Console.ReadLine());

int sharedEggs = gatheredEggs / 4;
int leftoverEggs = gatheredEggs % 4;

Console.WriteLine("Each sister receives: " + sharedEggs + " chocolate eggs.");
Console.WriteLine("The duckbear gets: " + leftoverEggs + " chocolate eggs.");

Console.ReadKey();

// Three total egg counts where the duckbear gets more than each sister does are:
// Example 1: When they have less than 4 eggs total -> Each sister gets 0, duckbear gets 1, 2, or 3 eggs depending on the total count
// Example 2: When they have 6 or 7 eggs -> Each sister gets 1, duckbear gets 2 or 3 eggs depending on the total count
// Example 3: 11 eggs -> Each sister gets 2, duckbear gets 3