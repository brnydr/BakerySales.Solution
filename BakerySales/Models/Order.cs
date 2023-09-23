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
    private static int _idCounter = 1;
    public int Id { get; }
    public Order(string title, string description, int price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _idCounter++;
      Id = _idCounter;
    }

    public static void ClearAll()
    {
      _idCounter = 0;
    }
  }
}