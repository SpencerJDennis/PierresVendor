using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendorMain.Models;

namespace PierresVendor.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

      [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string title = "Bacon Hamburger";
      Order newOrder = new Order(title, "11/13/2022", "Bacony Goodness", 10);
      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void EditedOrderTitle_EditedOrderTitle_String()
    {
      string title = "Bacon Hamburger.";
      Order newOrder = new Order(title, "11/13/2022", "Bacony Goodness", 10);
      
      string editedTitle = "Baconator";
      newOrder.Title = editedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(editedTitle, result);
    }

    [TestMethod]
    public void GetOrderDescrtiption_ReturnsOrderDescription_String()
    {
      string description = "Bacony Goodness";
      Order newOrder = new Order("Bacon Hamburger", "11/13/2022", description, 10);
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void EditsOrderDescription_EditsOrderDescription_String()
    {
      string description = "Bacony Goodness";
      Order newOrder = new Order("Bacon Hamburger", "11/13/2022", description, 10);
      
      string editedDescription = "Bacon filled hamburger with lots of sauce";
      newOrder.Description = editedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(editedDescription, result);
    }

     [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      string date = "11/13/2022";
      Order newOrder = new Order("Bacon Hamburger", date, "Bacony Goodness", 10);
      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void EditOrderDate_EditOrderDate_String()
    {
      string date = "11/13/2022";
      Order newOrder = new Order("Bacon Hamburger", date, "Bacony Goodness", 10);
      
      string editedDate = "11/14/2022";
      newOrder.Date = editedDate;
      string result = newOrder.Date;

      Assert.AreEqual(editedDate, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      int price = 10;
      Order newOrder = new Order("Bacon Hamburger", "11/13/2022",  "Bacony Goodness", price);
      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void EditOrderPrice_EditOrderPrice_Int()
    {
      int price = 10;
      Order newOrder = new Order("Bacon Hamburger", "11/13/2022", "Bacony Goodness", price);
      
      int editedPrice = 100;
      newOrder.Price = editedPrice;
      int result = newOrder.Price;

      Assert.AreEqual(editedPrice, result);
    }

    [TestMethod]
    public void OrderCreator_CreatesNewOrder_Order()
    {
      Order newOrder = new Order("Bacon Hamburger", "11/13/2022", "Bacony Goodness", 10);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}
