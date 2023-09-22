using System.Collections.Generic;

namespace BakerySales.Models
{
  public class Order
  {
    public string Description { get; set; }
    public Order(string description)
    {
      Description = description;
    }
  }
}