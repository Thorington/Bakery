using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;
using System;

namespace Bakery.ModelTests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
      public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastryItem = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastryItem.GetType());
    }
    
  }
}