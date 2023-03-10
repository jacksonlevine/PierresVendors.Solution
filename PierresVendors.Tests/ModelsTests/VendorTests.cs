using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void Vendor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor v = new Vendor();
      Assert.AreEqual(typeof(Vendor), v.GetType());
    }
    [TestMethod]
    public void Vendor_HasPublicNameProperty_String()
    {
      Vendor v = new Vendor();
      v.Name = "Test name";
      Assert.AreEqual("Test name", v.Name);
    }
    [TestMethod]
    public void Vendor_HasPublicDescriptionProperty_String()
    {
      Vendor v = new Vendor();
      v.Description = "Test description";
      Assert.AreEqual("Test description", v.Description);
    }
    [TestMethod]
    public void Vendor_HasPublicListOfOrders_ListOrder()
    {
      Vendor v = new Vendor();
      Assert.AreEqual(typeof(List<Order>), v.Orders.GetType());
    }
    [TestMethod]
    public void GetAll_StaticMethodReturnsAllInstancesOfVendor_ListVendor()
    {
      Assert.AreEqual(typeof(List<Vendor>), Vendor.GetAll().GetType());
    }
    [TestMethod]
    public void ClearAll_StaticMethodClearsInstanceList_Void()
    {
      Vendor.ClearAll();
      Assert.AreEqual(0, Vendor.GetAll().Count);
    }
    [TestMethod]
    public void Vendor_AddsItselfToStaticInstancesListWhenCreated_Void()
    {
      Vendor v = new Vendor();
      Vendor v2 = new Vendor();
      Vendor v3 = new Vendor();
      Assert.AreEqual(3, Vendor.GetAll().Count);
    }
    [TestMethod]
    public void Vendor_EachOneHasUniqueId_Int()
    {
      Vendor v = new Vendor();
      Vendor v2 = new Vendor();
      Vendor v3 = new Vendor();
      Assert.AreNotEqual(v.Id, v2.Id);
      Assert.AreNotEqual(v2.Id, v3.Id);
      Assert.AreNotEqual(v3.Id, v.Id);
      Assert.AreNotEqual(v.Id, v3.Id);
    }
    [TestMethod]
    public void Find_ReturnsVendorWithIdSpecifiedInArgument_Vendor()
    {
      Vendor v = new Vendor();
      v.Name = "Josh";
      Assert.AreEqual("Josh", Vendor.Find(0).Name);
    }
    [TestMethod]
    public void TotalSpent_ReturnsTotalAmountSpentOnThisVendor_Double()
    {
      Vendor v = new Vendor();
      Order o = new Order();
      o.Title = "200 Bagels";
      o.Price = 500.00;
      v.Orders.Add(o);
      Order o2 = new Order();
      o2.Title = "300 Bagels";
      o2.Price = 500.00;
      v.Orders.Add(o2);
      Assert.AreEqual(1000.00, v.TotalSpent());
    }
    [TestMethod]
    public void AverageSpent_ReturnsAverageAmountSpentWithThisVendor_Double()
    {
            Vendor v = new Vendor();
      Order o = new Order();
      o.Title = "200 Bagels";
      o.Price = 600.00;
      v.Orders.Add(o);
      Order o2 = new Order();
      o2.Title = "300 Bagels";
      o2.Price = 400.00;
      v.Orders.Add(o2);
      Assert.AreEqual(500.00, v.AverageSpent());
    }
  }
}