using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresVendorMain.Models;

namespace PierresVendorMain.Controllers{
  public class VendorsController : Controller{

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string newVendorName, string newVendorDescription)
    {
      Vendor newVendor = new Vendor(newVendorName, newVendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currentVendor = Vendor.Find(id);
      List<Order> vendorOrders = currentVendor.NewOrders;
      model.Add("vendor", currentVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string newOrderTitle, string newOrderDate, string newOrderDescription, int newOrderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor showVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(newOrderTitle, newOrderDate, newOrderDescription, newOrderPrice);
      showVendor.AddOrder(newOrder);
      List<Order> vendorOrders = showVendor.NewOrders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", showVendor);
      return View("Show", model);
    }
  }
}
