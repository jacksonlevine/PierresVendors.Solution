using PierresVendors.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

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
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor);
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor v = new Vendor();
      v.Name = name;
      v.Description = description;
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}/orders")]
    public ActionResult ViewOrders(int id)
    {
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor);
    }
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult NewOrder(int id)
    {
      return View(id);
    }
    [HttpPost("/vendors/{id}/orders")]
    public ActionResult CreateOrder(int id, string title, string description, string price, string date)
    {
      Vendor foundVendor = Vendor.Find(id);
      Order o = new Order();
      o.Title = title;
      o.Description = description;
      o.Price = double.Parse(price);
      o.Date = date;
      foundVendor.Orders.Add(o);
      return View("ViewOrders", foundVendor);
    }
  }
}