using System.Collections.Generic;

namespace PierresVendorMain.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> NewOrders { get; set; }

    public Vendor(string newVendorName, string newVendorDescription)
    {
      Name = newVendorName;
      Description = newVendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      NewOrders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public void AddOrder(Order newOrder)
    {
      NewOrders.Add(newOrder);
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}