using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTests
  {
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
      v.Name = "Test";
      Assert.AreEqual("Test", v.Name);
    }
  }
}