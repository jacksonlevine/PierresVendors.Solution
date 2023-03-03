using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;

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
    [TestMethod]
    public void Order_HasPublicTitleProperty_String()
    {
      Order o = new Order();
      o.Title = "Test title";
      Assert.AreEqual("Test title", o.Title);
    }
    [TestMethod]
    public void Order_HasPublicDescriptionProperty_String()
    {
      Order o = new Order();
      o.Description = "Test description";
      Assert.AreEqual("Test description", o.Description);
    }
    [TestMethod]
    public void Order_HasPublicPriceProperty_Double()
    {
      Order o = new Order();
      o.Price = 25.00;
      Assert.AreEqual(25.00, o.Price);
    }
    [TestMethod]
    public void Order_HasPublicDateProperty_DateTime()
    {
      Order o = new Order();
      Assert.AreEqual(typeof(string), o.Date.GetType());
    }
  }
}