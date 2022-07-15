using System;


namespace Bakery
{
  public class Pastry
  {
    public int NumberOfPastries { get; set; }
    public int BasePricePastry {get; set; }


    public Pastry(int numberOfPastries, int basePricePastry)
  {
    NumberOfPastries = numberOfPastries;
    BasePricePastry = basePricePastry;
  }

    public string GetPastryPrice(int numberOfPastries, int basePricePastry)
  {
    if (numberOfPastries == 1)
    {
      return basePricePastry;
    }
    // else if (numberOfPastries % 2 == 0)
    // {
    //   return ((numberOfPastries * basePricePastry) * (2/3)).ToString("");
    // }
    // else if (numberOfPastries % 2 == 1)
    // {
    //   return (((numberOfPastries - 1) * (2/3)) + basePricePastry).ToString("");
    // }
    // else
    // {
    //   return ("There was an error.");
    // }
  }
  }
}