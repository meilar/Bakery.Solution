using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public int Amount { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public string Due { get; set; }
    public string Notes { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(int amount, string description, string due, string notes)
    {
      Amount = amount;
      Description = description;
      Due = due;
      Notes = notes;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}