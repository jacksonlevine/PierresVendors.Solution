using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Order_CreatesInstanceOfOrder_Order()
    {
      Order o = new Order();
      Assert.AreEqual(typeof(Order), o.GetType());
    }
  }
}