using System;

namespace Bakery
{
  public class Program
  {
  
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! We've got a few slammin' deals for you. Bread is $5 per loaf, two loaves for $10, and we're currently running a buy 2, get 1 free special! Pastries are $2 each, 3 for $5, 4 for $7, 5 for $9, or 6 for $10. Would you like to order something? Yes/No");
    string stringYesNoOrder = Console.ReadLine();
    if (stringYesNoOrder.ToLower() == "yes")
    {
      Console.WriteLine("You smart cookie! Hahaha, see what we did there? Yes/No");
      string stringYesNoUnderstand = Console.ReadLine();
      if (stringYesNoUnderstand.ToLower() == "yes")
      {
        Console.WriteLine("How many loaves of bread would you like to order? Please enter a number:");
        string stringNumberOfLoavesToOrder = Console.ReadLine();
        int intNumberOfLoavesToOrder = int.Parse(stringNumberOfLoavesToOrder);
        Console.WriteLine("How many pastries would you like to order? Please enter a number:");
        string stringNumberOfPastriesToOrder = Console.ReadLine();
        int intNumberOfPastriesToOrder = int.Parse(stringNumberOfPastriesToOrder);
        orderTotal = (intNumberOfLoavesToOrder.getPrice()) + (intNumberOfPastriesToOrder.getPrice());
        Console.WriteLine("Thanks for your order! Your total is: " + orderTotal)
      }
      if (stringYesNoUnderstand.ToLower() == "no")
      Console.WriteLine("Let's try this again. You're at a shop that sells baked goods. Think about what a cookie is.");
      Main();
    }
    if (stringYesNoOrder.ToLower() == "no")
    {
      Console.WriteLine("Maybe you didn't hear about our slammin' deals.");
      Main();
    }

  }
  }
}