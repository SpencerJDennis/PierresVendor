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
  }
}