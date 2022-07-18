using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;
using System;

namespace Bakery.ModelTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
      public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread();
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
    
  }
}