using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description; // this is a property
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
  }
}
