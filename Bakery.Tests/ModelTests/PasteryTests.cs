using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
  [TestMethod]
    public void CalcCost_BuyOneForTwoDollars_True()
    {
      Pastry buyOne = new Pastry(1);
      buyOne.CalcCost();
      Assert.AreEqual(2, buyOne.TotalCost);
    }

    [TestMethod]
      public void CalcCost_BuyTwoForFourDollars_True()
      {
        Pastry buyTwo = new Pastry(2);
        buyTwo.CalcCost();
        Assert.AreEqual(4, buyTwo.TotalCost);
      }
    [TestMethod]
      public void CalcCost_BuyThreeForSixDollars_True()
      {
        Pastry buyThree = new Pastry(3);
        buyThree.CalcCost();
        Assert.AreEqual(6, buyThree.TotalCost);
      }

    [TestMethod]
      public void CalcCost_BuyFourForSixDollars_True()
      {
        Pastry buyFour = new Pastry(4);
        buyFour.CalcCost();
        Assert.AreEqual(6, buyFour.TotalCost);
      }

    [TestMethod]
      public void CalcCost_BuyFiveForEight_True()
      {
        Pastry buyFive = new Pastry(5);
        buyFive.CalcCost();
        Assert.AreEqual(8, buyFive.TotalCost);
      }
    
    [TestMethod]
      public void CalcCost_BuySixForTen_True()
      {
        Pastry buySix = new Pastry(6);
        buySix.CalcCost();
        Assert.AreEqual(10, buySix.TotalCost);
      }

    [TestMethod]
      public void CalcCost_BuySevenForTwelve_True()
      {
        Pastry buySeven = new Pastry(7);
        buySeven.CalcCost();
        Assert.AreEqual(12, buySeven.TotalCost);
      }
  }
}