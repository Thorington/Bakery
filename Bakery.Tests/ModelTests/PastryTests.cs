using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.ModelTests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
      public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastryItem = new Pastry("test", 2);
      Assert.AreEqual(typeof(Pastry), newPastryItem.GetType());
    }
    
  }
}