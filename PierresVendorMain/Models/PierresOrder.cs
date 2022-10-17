using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class PierresOrder
  {
    public string Title  { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public int Date { get; set; }
    public int Id { get; }
    private static List<PierresOrder> _instances = new List<PierresOrder> { };

    public Order(string title, string date, string description, int price)
    {
      Title = title;
      Date = date;
      Description = description;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }