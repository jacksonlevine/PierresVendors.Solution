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
    }
    public Vendor()
    {
      _allinstances.Add(this);
      Id = _currentId;
      _currentId++;
    }
  }
}