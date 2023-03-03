using System.Collections.Generic;
namespace PierresVendors.Models
{
  public class Vendor
  {
    private static List<Vendor> _allinstances = new List<Vendor>();
    public string Name { get; set; }
    public string Description { get; set; }
    private static int _currentId = 0;
    public int Id { get; set; }
    public List<Order> Orders = new List<Order>();
    public static List<Vendor> GetAll()
    {
      return _allinstances;
    }
    public static void ClearAll()
    {
      _allinstances.Clear();
      _currentId = 0;
    }
    public Vendor()
    {
      _allinstances.Add(this);
      AssignId();
    }
    public void AssignId()
    {
      Id = _currentId;
      _currentId++;
    }
    public static Vendor Find(int id)
    {
      if(_allinstances.Exists(ven => ven.Id == id))
      {
        return _allinstances.Find(ven => ven.Id == id);
      }
      return null;
    }

    public double TotalSpent()
    {
      double price = 0;
      foreach(Order o in Orders)
      {
        price += o.Price;
      }
      return price;
    }
  }
}