using System;


namespace Bakery
{
  public class Pastry
  {
    public double PastryOrder { get; set; }

    public void PastryObject(double pastryOrder)
  {
    PastryOrder = pastryOrder;
  }

    public double GetPastryPrice(double pastryOrder)
  {
    double numberAtFullPrice = pastryOrder%3;
    double numberAtDiscount = Math.Floor(pastryOrder/3);
    double fullPriceCost = numberAtFullPrice*2;
    double discountCost = numberAtDiscount*5;
    return fullPriceCost + discountCost;
  }
  }
}