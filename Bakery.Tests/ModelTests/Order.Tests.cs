using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
      private int _testAmount = 10;
      private string _testDescription = "Walk the dog.";

      private string _testDue = "tomorrow";
      private string _testNotes = "this is a test order";

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order(_testAmount, _testDescription, _testDue, _testNotes);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      Order newOrder = new Order(_testAmount, _testDescription, _testDue, _testNotes);
      string result = newOrder.Description;
      Assert.AreEqual(_testDescription, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      Order newOrder = new Order(_testAmount, _testDescription, _testDue, _testNotes);
      int newAmount = 5;
      newOrder.Amount = newAmount;
      Assert.AreNotEqual(_testAmount, newOrder.Amount);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      Order newOrder = new Order(_testAmount, _testDescription, _testDue, _testNotes);
      Order newerOrder = new Order(_testAmount, _testDescription, _testDue, _testNotes);
      List<Order> newList = new List<Order> { newOrder, newerOrder };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsOrder_Order()
    {
      Order newOrder = new Order(_testAmount, _testDescription, _testDue, _testNotes);
      int searchId = newOrder.Id;
      Order result = Order.Find(searchId);
      CollectionAssert.Equals(result, newOrder);
    }
  }
}