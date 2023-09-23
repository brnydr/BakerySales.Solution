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

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_List()
    {
      string description1 = "new description";
      string name1 = "new vendor";
      string description2 = "new description";
      string name2 = "new vendor";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      CollectionAssert.AreEqual(newList, Vendor.GetAll());
    }

    [TestMethod]
    public void Find_ReturnsVendor_Vendor()
    {
      string description1 = "new description";
      string name1 = "new vendor";
      string description2 = "new description";
      string name2 = "new vendor";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      Assert.AreEqual(newVendor2, Vendor.Find(2));
    }

  }

  
}