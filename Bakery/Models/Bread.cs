using System;


namespace Bakery
{
  public class Bread
  {
    public int NumberOfLoaves { get; set; }

    public void BreadObject(int numberOfLoaves)
  {
    NumberOfLoaves = numberOfLoaves;
  }

    public int GetBreadPrice(int numberOfLoaves)
  {
    if (numberOfLoaves == 1)
    {
      return 5;
    }
    else if (numberOfLoaves % 2 == 0)
    {
      return ((numberOfLoaves * 5) * (2/3));
    }
    else if (numberOfLoaves % 2 == 1)
    {
      return (((numberOfLoaves - 1) * (2/3)) + 5);
    }
    else
    {
      return (000000);
    }
  }
  }
}