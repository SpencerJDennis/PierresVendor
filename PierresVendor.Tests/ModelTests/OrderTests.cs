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

     [TestMethod]
    public void ReturnCurrentEmptyList_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ReturnsAllOrders_ReturnsCurrentOrders_OrderList()
    {
      string orderTitle1 = "Bacon Hamburger";
      string orderTitle2 = "Yucky Garbage";
      string orderDate1 = "11/13/2022";
      string orderDate2 = "11/14/2022";
      string orderDescription1 = "Bacony Goodness";
      string orderDescription2 = "Disgusting Garbage";
      int orderPrice1 = 10;
      int orderPrice2 = 2;
      Order newOrder1 = new Order(orderTitle1, orderDate1, orderDescription1, orderPrice1);
      Order newOrder2 = new Order(orderTitle2, orderDate2, orderDescription2, orderPrice2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}
