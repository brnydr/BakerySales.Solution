using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakerySales.Models;
using System;

namespace BakerySales.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      DateTime date = new DateTime(2021, 1, 1);
      Order newOrder = new Order("title", "description", 9, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsOrder_Order()
    {
      DateTime date = new DateTime(2021, 1, 1);
      Order newOrder1 = new Order("title", "description", 9, date);
      Order newOrder2 = new Order("title", "description", 10, date);
      Assert.AreEqual(newOrder2, Order.Find(2));
    }

  }
}