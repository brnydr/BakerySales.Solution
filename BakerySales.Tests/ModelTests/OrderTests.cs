using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakerySales.Models;
using System;

namespace BakerySales.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "new description";
      Order newOrder = new Order("title", description);
      Assert.AreEqual(description, newOrder.Description);
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "new title";
      Order newOrder = new Order(title, "description");
      Assert.AreEqual(title, newOrder.Title);
    }

  }
}