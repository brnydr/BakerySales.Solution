using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySales.Models;
using System.Collections.Generic;
using System;

namespace BakerySales.Tests 
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("new vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "new vendor";
      Vendor newVendor = new Vendor(name);
      
      Assert.AreEqual(name, newVendor.Name);
    }
  }
}