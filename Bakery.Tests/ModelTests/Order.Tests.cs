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

  //   [TestMethod]
  //   public void GetAll_ReturnsEmptyList_ItemList()
  //   {
  //     // Arrange
  //     List<Order> newList = new List<Order> { };

  //     // Act
  //     List<Order> result = Order.GetAll();

  //     // Assert
  //     CollectionAssert.AreEqual(newList, result);
  //   }

  //   [TestMethod]
  //   public void GetAll_ReturnsItems_ItemList()
  //   {
  //     //Arrange
  //     string description01 = "Walk the dog";
  //     string description02 = "Wash the dishes";
  //     Order newItem1 = new Order(description01);
  //     Order newItem2 = new Order(description02);
  //     List<Order> newList = new List<Order> { newItem1, newItem2 };

  //     //Act
  //     List<Order> result = Order.GetAll();

  //     //Assert
  //     CollectionAssert.AreEqual(newList, result);
  //   }
  }
}