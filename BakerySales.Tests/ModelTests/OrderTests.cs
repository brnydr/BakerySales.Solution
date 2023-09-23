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
      DateTime date = new DateTime(2021, 1, 1);
      Order newOrder = new Order("title", "description", 9, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "new description";
      DateTime date = new DateTime(2021, 1, 1);
      Order newOrder = new Order("title", description, 9, date);
      Assert.AreEqual(description, newOrder.Description);
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "new title";
      DateTime date = new DateTime(2021, 1, 1);
      Order newOrder = new Order(title, "description", 9, date);
      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 9;
      DateTime date = new DateTime(2021, 1, 1);
      Order newOrder = new Order("title", "description", 9, date);
      Assert.AreEqual(price, newOrder.Price);
    }
    [TestMethod]
    public void GetDate_ReturnsDate_Date()
    {
      DateTime date = new DateTime(2021, 1, 1);
      Order newOrder = new Order("title", "description", 9, date);
      Assert.AreEqual(date, newOrder.Date);
    }

  }
}