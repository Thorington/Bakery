using System;


namespace Bakery
{
  public class Pastry
  {
    public string NumberOfPastries {get; set; }
    public int Price {get; set; }

    public Pastry(string numberOfPastries, int price)
  {
    NumberOfPastries = numberOfPastries;
    Price = price;
  }

  //   public int GetBreadPrice()
  // {
  //   return _price;
  // }

  //  public static int BreadDeal(Bread loaf, int newPrice)
  // {
  //   return bread._price * newPercentage;
  // }
  }
}