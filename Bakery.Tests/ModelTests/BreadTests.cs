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

    // [TestMethod]
    //   public void GetBreadOrder_ReturnsBreadOrder_Bread()
    //   {
    //     //Arrange
    //     double NumberOfLoaves = 2;

    //     //Act
    //     Bread newBread = new Bread(NumberOfLoaves);
    //     double result = newBread.NumberOfLoaves;

    //     //Assert
    //     Assert.AreEqual(NumberOfLoaves, result);
    //   }
    
  }
}