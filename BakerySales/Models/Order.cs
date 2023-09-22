using System.Collections.Generic;

namespace BakerySales.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public Order(string title, string description)
    {
      Title = title;
      Description = description;
    }
  }
}