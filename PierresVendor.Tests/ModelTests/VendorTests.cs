using System.Reflection;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendorMain.Models;

namespace PierresVendor.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      string name1 = "Scanders Sandwich Shop";
      string name2 = "Wendys";
      Vendor newVendor1 = new Vendor(name1, "hello");
      Vendor newVendor2 = new Vendor(name2, "hello");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void NewVendorCreation_CreatesANewVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Wendys", "hamburger restaurant");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void Getname_ReturnsName_String()
    {
      string name = "Wendys";
      Vendor newVendor = new Vendor(name, "a hamburger restaurant");

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDesciption_ReturnsDescription_String()
    {
      string description = "A Hamburger Restaurant";
      Vendor newVendor = new Vendor("Wendys", description);

      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Wendys";
      string description = "A hamburger restaurant";
      Vendor newVendor = new Vendor(name, description);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void AddOrderToVendor_AddAnOrderToAVendor_OrderList()
    {
      Order newOrder = new Order("Wendys", "11/09/2022", "A Big Ol Hamburger", 2);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Wendys";
      string description = "A Hamburger Place";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.NewOrders;
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsVendorViaId_Vendor()
    {
      Vendor newVendor1 = new Vendor("Scanders Sandwich Shop", "Yummy Sandwiches for sure");
      Vendor newVendor2 = new Vendor("Wendys", "A hamburger restaurant");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
  }
}