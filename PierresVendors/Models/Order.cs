using System;
namespace PierresVendors.Models
{
  public class Order
  {
    public string Title { get; set; } 
    public string Description { get; set; }
    public double Price { get; set; }
    public string Date { get; set; }
  }
}