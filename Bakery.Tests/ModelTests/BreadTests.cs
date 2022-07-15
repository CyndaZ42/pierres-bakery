using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // Test methods go here
    [TestMethod]
    public void IsBread_checksIfBread_True()
    {
      Bread someBread = new Bread(1);
      Assert.AreEqual(true, someBread.IsBread());
    }

    [TestMethod]
    public void Cost_checksBreadCost_Int()
    {
      Assert.AreEqual(5, Bread.Cost);
    }

    [TestMethod]
    public void CalcTotalCost_CalculatesCostOfBreadAmount_Int()
    {
      int breadAmount = 1;
      Bread someBread = new Bread(breadAmount);
      someBread.CalcTotalCost();
      Assert.AreEqual(5, someBread.TotalCost);
    }

    [TestMethod]
    public void CalcTotalCost_CalculatesDiscountOnBread_Int()
    {
      int breadAmount = 3;
      Bread someBread = new Bread(breadAmount);
      someBread.CalcTotalCost();
      Assert.AreEqual(10, someBread.TotalCost);
    }
  }
}