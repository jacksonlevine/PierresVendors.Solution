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
  }
}