using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/Vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/Vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/Vendors")]
    public ActionResult Create(string vendorName, string vendorAddress, string vendorNotes)
    {
      Vendor newVendor = new Vendor(vendorName, vendorAddress, vendorNotes);
      return RedirectToAction("Index");
    }

    [HttpGet("/Vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("Vendor", selectedVendor);
      model.Add("Orders", vendorOrders);
      return View(model);
    }


    // This one creates new Orders within a given Vendor, not new Vendors:

    [HttpPost("/Vendors/{vendorId}/Orders")]
    public ActionResult Create(int vendorId, int orderAmount, string orderDescription, string orderDue, string orderNotes)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderAmount, orderDescription, orderDue, orderNotes);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("Orders", vendorOrders);
      model.Add("Vendor", foundVendor);
      return View("Show", model);
    }

  }
}