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
      Vendor vendor = Vendor.Find(id);
      return View(vendor);
    }


    [HttpPost("/Vendors/{vendorId}/Orders")]
    public ActionResult Create(int vendorId, int orderAmount, string orderDescription, string orderDue, string orderNotes)
    {
      Order newOrder = new Order(orderAmount, orderDescription, orderDue, orderNotes);
      return RedirectToAction("Show", new {id= vendorId});
    }

  }
}