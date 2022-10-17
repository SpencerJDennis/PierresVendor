using System.Collections.Generic;

namespace PierresVendorMain.Models
{
  public class Order
  {
    public string Title  { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public int Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public PierresOrder(string title, string date, string description, int price)
    {
      Title = title;
      Date = date;
      Description = description;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}