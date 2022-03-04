using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public int Id { get; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Notes { get; set; }
    public int Balance { get; }

    public List<Order> Orders { get; set; }

    public Vendor(string name, string address, string notes)
    {
      Balance = 0;
      Name = name;
      Address = address;
      Notes = notes;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    // public void AddItem(Item item)
    // {
    //   Items.Add(item);
    // }

  }
}