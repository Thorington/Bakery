using System;


namespace Bakery
{
  public class Bread
  {
    public int NumberOfLoaves { get; set; }
    public int BasePriceBread {get; set; }


    public Bread(int numberOfLoaves, int basePriceBread)
  {
    NumberOfLoaves = numberOfLoaves;
    BasePriceBread = basePriceBread;
  }

    public string GetBreadPrice(int numberOfLoaves, int basePriceBread)
  {
    if (numberOfLoaves == 1)
    {
      return basePriceBread.ToString("");
    }
    // else if (numberOfLoaves % 2 == 0)
    // {
    //   resultMultipleLoavesEven = ((numberOfLoaves * basePriceBread) * (2/3)).ToString("");
    //   return resultMultipleLoavesEven;
    // }
    // else if (numberOfLoaves % 2 == 1)
    // {
    //   resultMultipleLoavesOdd = (((numberOfLoaves - 1) * (2/3)) + basePriceBread).ToString("");
    //   return resultMultipleLoavesOdd;
    // }
  }
  }
}