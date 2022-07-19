using System;


namespace Bakery
{
  public class Pastry
  {
    public int NumberOfPastries { get; set; }

    public void PastryObject(int numberOfPastries)
  {
    NumberOfPastries = numberOfPastries;
  }

    public int GetPastryPrice(int numberOfPastries)
  {
    // if (numberOfPastries==1)
    // {
    //   return 2;
    // }
    // else if (numberOfPastries%2==0)
    // {
    //   return ((numberOfPastries*2)*(2/3));
    // }
    // else if (numberOfPastries%2==1)
    // {
    //   return (((numberOfPastries-1)*(2/3))+2);
    // }
    // else
    // {
    //   return (000000);
    // }
  }
  }
}