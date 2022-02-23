using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the ToDo List");
      while (true)
      {
        Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View/Done)");
        string userAdVi = Console.ReadLine().ToUpper();
        if (userAdVi == "ADD")
        {
          Console.WriteLine("Describe your new ToDo item");
          string userItem = "- " + Console.ReadLine();
          Item newItem = new Item(userItem);
          List<Item> newList = new List<Item> { newItem };
          Console.WriteLine(userItem + " has been added to your list.");
          // Main();
        }
        else if (userAdVi == "VIEW")
        {
          foreach (Item item in Item.GetAll())
          {
            Console.WriteLine(item.Description);
          }
          // Main();
        }
        else if (userAdVi == "DONE")
        {
          return;
        }
        else
        {
          Console.WriteLine("Invalid entry.");
          // Main();
        }
      }
    }
  }
}
