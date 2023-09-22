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
      Order newOrder = new Order("title", "description", 9);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "new description";
      Order newOrder = new Order("title", description, 9);
      Assert.AreEqual(description, newOrder.Description);
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "new title";
      Order newOrder = new Order(title, "description", 9);
      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 9;
      Order newOrder = new Order("title", "description", price);
      Assert.AreEqual(price, newOrder.Price);
    }

  }
}