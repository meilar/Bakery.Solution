using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newItem = new Order(12, "two bread", "2022-06-20", "for customer's birthday");
      Assert.AreEqual(typeof(Order), newItem.GetType());
    }

  //   [TestMethod]
  //   public void GetDescription_ReturnsDescription_String()
  //   {
  //     //Arrange
  //     string description = "Walk the dog.";

  //     //Act
  //     Order newItem = new Order(description);
  //     string result = newItem.Description;

  //     //Assert
  //     Assert.AreEqual(description, result);
  //   }

  //   [TestMethod]
  //   public void SetDescription_SetDescription_String()
  //   {
  //     //Arrange
  //     string description = "Walk the dog.";
  //     Order newItem = new Order(description);

  //     //Act
  //     string updatedDescription = "Do the dishes";
  //     newItem.Description = updatedDescription;
  //     string result = newItem.Description;

  //     //Assert
  //     Assert.AreEqual(updatedDescription, result);
  //   }

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