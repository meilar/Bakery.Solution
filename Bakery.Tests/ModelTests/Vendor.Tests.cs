using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

      private string _testName = "Harpo's Trattoria Cubana";
      private string _testAddress = "8 Calle Italiano, Portland, Oregon";

      private string _testNotes = "this is a test vendor";

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor(_testName, _testAddress, _testNotes);
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      Vendor testVendor = new Vendor(_testName, _testAddress, _testNotes);
      string updatedName = "Updated name";
      testVendor.Name = updatedName;
      string result = testVendor.Name;
      Assert.AreEqual(result, updatedName);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor testVendor = new Vendor(_testName, _testAddress, _testNotes);
      int result = testVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      Vendor testVendor = new Vendor(_testName, _testAddress, _testNotes);
      Vendor testVendor2 = new Vendor(_testName, _testAddress, _testNotes);
      List<Vendor> testList = new List<Vendor> { testVendor, testVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor testVendor = new Vendor (_testName, _testAddress, _testNotes);
      int searchId = testVendor.Id;
      Vendor result = Vendor.Find(searchId);
      CollectionAssert.Equals(result, testVendor);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_VendorList()
    {
      Order testOrder = new Order(12, "test description", "test date","test notes");
      List<Order> testList = new List<Order> { testOrder };
      Vendor testVendor = new Vendor (_testName, _testAddress, _testNotes);
      testVendor.AddOrder(testOrder);
      List<Order> result = testVendor.Orders;
      CollectionAssert.AreEqual(testList, result);
    }

    public void AddOrder_UpdatesBalance_VendorBalance()
    {
      Order testOrder = new Order(12, "test description", "test date","test notes");
      Vendor testVendor = new Vendor (_testName, _testAddress, _testNotes);
      testVendor.AddOrder(testOrder);
      Assert.AreEqual(testOrder.Amount, testVendor.Balance);
    }
    
  }
}