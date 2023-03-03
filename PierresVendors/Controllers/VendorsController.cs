using PierresVendors.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PierresVendors.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVends = Vendor.GetAll();
      return View(allVends);
    }
    [HttpGet("/vendors/new")]
    public ActionResult Form()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor v = new Vendor();
      v.Name = name;
      v.Description = description;
      return RedirectToAction("Index");
    }
  }
}