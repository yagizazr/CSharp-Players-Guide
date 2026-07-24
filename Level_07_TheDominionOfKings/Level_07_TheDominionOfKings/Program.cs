    

    Console.Write("Please enter the estate amount: ");
    int estateAmount = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please enter the duchy amount: ");
    int duchyAmount = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please enter the province amount: ");
    int provinceAmount = Convert.ToInt32(Console.ReadLine());

    int totalPoints = estateAmount + duchyAmount * 3 + provinceAmount * 6;
    Console.WriteLine("Total points: " + totalPoints);

    Console.ReadKey();