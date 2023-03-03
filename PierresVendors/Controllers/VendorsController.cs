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
  }
}