using System;

namespace Bakery
{
  public class Program
  {
  
  public static void Main()
  {
    // Bread newBreadOrder = new Bread(1, 5);
    // Pastry newPastryOrder = new Pastry(1, 2);

    Console.WriteLine("Welcome to Pierre's Bakery! Today we've got a few slammin' deals for you. Bread is $5 per loaf, two loaves for $10, and we're currently running a buy 2, get 1 free special! Pastries are $2 each, 3 for $5, 4 for $7, 5 for $9, or 6 for $10. Would you like to order something? Yes/No");
    string stringYesNoOrder = Console.ReadLine();
    if (stringYesNoOrder == "Yes")
    {
      Console.WriteLine("You smart cookie! Hahaha, see what we did there? Yes/No");
      string stringYesNoUnderstand = Console.ReadLine();
      if (stringYesNoUnderstand == "Yes")
      {
        Console.WriteLine("How many loaves of bread would you like to order? Please enter a number:");
        string stringNumberOfLoavesToOrder = Console.ReadLine();
        int intNumberOfLoavesToOrder = int.Parse(stringNumberOfLoavesToOrder);
        Console.WriteLine("How many pastries would you like to order? Please enter a number:");
        string stringNumberOfPastriesToOrder = Console.ReadLine();
        int intNumberOfPastriesToOrder = int.Parse(stringNumberOfPastriesToOrder);
      }
      if (stringYesNoUnderstand == "No")
      Main();
    }
    if (stringYesNoOrder == "No")
    {
      Console.WriteLine("Maybe you didn't hear about our slammin' deals.");
      Main();
    }

  }
  }
}