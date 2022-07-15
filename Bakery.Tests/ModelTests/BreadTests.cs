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
  }
}