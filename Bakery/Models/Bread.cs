using System;


namespace Bakery.Models
{
  public class Bread
  {
    public string Loaf {get; set; }
    public int Price {get; set; }

    public Bread(string loaf, int price)
  {
    Loaf = loaf;
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