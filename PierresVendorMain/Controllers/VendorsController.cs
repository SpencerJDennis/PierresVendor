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
  }
}
