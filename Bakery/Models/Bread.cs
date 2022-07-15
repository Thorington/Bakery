using System;


namespace Bakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves {get; set; }
    public int Price {get; set; }

    public Bread(int numberOfLoaves, int price)
  {
    NumberOfLoaves = numberOfLoaves;
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