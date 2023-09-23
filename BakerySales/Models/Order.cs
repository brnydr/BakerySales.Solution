using System;
using System.Collections.Generic;

namespace BakerySales.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set; }
    private static List<Order> _instances = new List<Order> {};
    private static int _idCounter = 0;
    public int Id { get; }
    public Order(string title, string description, int price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _idCounter++;
      Id = _idCounter;
      _instances.Add(this);
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
      _idCounter = 0;
    }
  }
}