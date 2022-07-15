using System;


namespace Bakery
{
  public class Pastry
  {
    public string PastryKind {get; set; }
    public int Price {get; set; }

    public Pastry(string pastryKind, int price)
  {
    PastryKind = pastryKind;
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