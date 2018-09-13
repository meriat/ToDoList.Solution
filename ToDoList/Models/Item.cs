using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description; // this is a property
    private static List<Item> _instances = new List<Item> {};
    private int _id;

    public Item (string description)  //constructor
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetDescription() //method
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Item> GetAll()
    {
      // return new List<Item> {};
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

  // public class Program
  // {
  //   public static void Main()
  //   {
  //     Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
  //
  //     string userAddOrView = Console.ReadLine();
  //
  //     if (userAddOrView == "Add")
  //     {
  //       Console.WriteLine("Please enter the description for the new item:");
  //       string descriptionInput = Console.ReadLine();
  //       Item newItem = new Item(descriptionInput);
  //       newItem.Save();
  //       Main();
  //     }
  //     else if (userAddOrView == "View")
  //     {
  //       Console.WriteLine("Here is your list:");
  //       List<Item> listInput = Item.GetAll();
  //
  //       foreach (Item itemToDo in listInput)
  //       {
  //         Console.WriteLine(itemToDo.GetDescription());
  //       }
  //       Main();
  //     }
  //     else if (userAddOrView == "" || userAddOrView != "Add" || userAddOrView != "View")
  //     {
  //       Console.WriteLine("Please enter a valid option, Add or View");
  //       Main();
  //     }
  //   }
  // }
}
