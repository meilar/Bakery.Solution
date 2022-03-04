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

    // [TestMethod]
    // public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    // {
    //   //Arrange
    //   string name01 = "Work";
    //   string name02 = "School";
    //   Vendor newCategory1 = new Vendor(name01);
    //   Vendor newCategory2 = new Vendor(name02);
    //   List<Vendor> newList = new List<Vendor> { newCategory1, newCategory2 };

    //   //Act
    //   List<Vendor> result = Vendor.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectCategory_Category()
    // {
    //   //Arrange
    //   string name01 = "Work";
    //   string name02 = "School";
    //   Vendor newCategory1 = new Vendor(name01);
    //   Vendor newCategory2 = new Vendor(name02);

    //   //Act
    //   Vendor result = Vendor.Find(2);

    //   //Assert
    //   Assert.AreEqual(newCategory2, result);
    // }

    // [TestMethod]
    // public void AddItem_AssociatesItemWithCategory_ItemList()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //   List<Item> newList = new List<Item> { newItem };
    //   string name = "Work";
    //   Vendor newCategory = new Vendor(name);
    //   newCategory.AddItem(newItem);

    //   //Act
    //   List<Item> result = newCategory.Items;

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
    
  }
}