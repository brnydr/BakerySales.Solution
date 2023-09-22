using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySales.Models;
using System.Collections.Generic;
using System;

namespace BakerySales.Tests 
{
  [TestClass]
  public class VendorTests : IDisposable 
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("new vendor", "new description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "new vendor";
      string description = "new description";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(name, newVendor.Name);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "new description";
      string name = "new vendor";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(description, newVendor.Description);
    }
    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      string description = "new description";
      string name = "new vendor";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }
}