using System;


namespace Bakery
{
  public class Bread
  {
    public double NumberOfLoaves{ get; set; }

  //Everything falls apart if the object is just called "Bread" so I'm wondering if I'm screwing up somewhere important with this whole thing.

    public void BreadObject(int numberOfLoaves)
  {
    NumberOfLoaves = numberOfLoaves;
  }

    public double GetBreadPrice(double numberOfLoaves)
  {
    int runningTotal = 0;
    int minOrderForDiscount = 2;
    int counter = 0;

    for(int i = 0; i < numberOfLoaves; i++)
    {
      if(counter < minOrderForDiscount)
      {
      runningTotal += 5;
      counter++;
      }
      else
      {
        counter = 0;
      }
    }
    return runningTotal;
  }
  }
}
