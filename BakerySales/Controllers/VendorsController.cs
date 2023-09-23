using System.Collections.Generic;
using BakerySales.Models;
using Microsoft.AspNetCore.Mvc;

namespace BakerySales.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }  

    [HttpPost("/vendors")]
    public ActionResult Index(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }
  }
}