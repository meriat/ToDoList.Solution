using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description; // this is a property
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)  //constructor
    {
      _description = description;
    }
    public string GetDescription() //method
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Item> GetAll()
    {
      // return new List<Item> {};
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
