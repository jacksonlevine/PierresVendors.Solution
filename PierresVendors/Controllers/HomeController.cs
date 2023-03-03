using PierresVendors.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PierresVendors.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}