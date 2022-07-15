using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    // Test methods go here
    [TestMethod]
    public void IsPastry_checksIfPastry_True()
    {
      int pastryAmount = 1;
      Pastry somePastry = new Pastry(pastryAmount);
      Assert.AreEqual(true, somePastry.IsPastry());
    }

    [TestMethod]
    public void Cost_checksPastryCost_Int()
    {
      Assert.AreEqual(2, Pastry.Cost);
    }
  }
}