using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // Test methods go here
  [TestMethod]

    public void CalcCost_BuyOneForFiveDollars_True()
    {
      //any logic prep goes here
      Bread buyOne = new Bread(1);
      buyOne.CalcCost();
      Assert.AreEqual(5, buyOne.TotalCost);
    }

      [TestMethod]
    public void CalcCost_BuyTwoForTenDollars_True()
    {
      Bread buyTwo = new Bread(2);
      buyTwo.CalcCost();
      Assert.AreEqual(10, buyTwo.TotalCost);
    }
  }
}