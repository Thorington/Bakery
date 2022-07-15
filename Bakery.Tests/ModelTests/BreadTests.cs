using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.ModelTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
      public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newLoaf = new Bread("test", 5);
      Assert.AreEqual(typeof(Bread), newLoaf.GetType());
    }
    
  }
}