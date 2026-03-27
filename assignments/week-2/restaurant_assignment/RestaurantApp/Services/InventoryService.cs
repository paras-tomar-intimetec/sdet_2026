using System;
using System.IO;
using System.Collections.Generic;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class InventoryService
    {
        private List<Ingredient> ingredients = new List<Ingredient>();

        //file added for inventory 
        private string filePath = "inventory.txt";

        // Add stock
        public void AddStock(string name, int quantity)
        {
            Ingredient existing = ingredients.Find(i => i.Name.ToLower() == name.ToLower());

            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                ingredients.Add(new Ingredient
                {
                    Name = name,
                    Quantity = quantity
                });
            }
        }

        // View inventory
        public void ShowInventory()
        {
            Console.WriteLine("\nInventory:");

            foreach (var item in ingredients)
            {
                Console.WriteLine(item.Name + " : " + item.Quantity);
            }
        }
        

        // Reduce stock
        public void ReduceStock(string name, int quantity)
        {
            Ingredient existing = ingredients.Find(i => i.Name.ToLower() == name.ToLower());

            if (existing != null)
            {
                if (existing.Quantity >= quantity)
                {
                    existing.Quantity -= quantity;
                }
                else
                {
                    Console.WriteLine("Not enough stock for " + name);
                }
            }
            else
            {
                Console.WriteLine("Item not found in inventory");
            }
        }
        public void SaveToFile()
        {
          List<string> lines = new List<string>();

          for (int i = 0; i < ingredients.Count; i++)
          {
            string line = ingredients[i].Name + "," + ingredients[i].Quantity;
            lines.Add(line);
          }

          File.WriteAllLines(filePath, lines);
        }

        public void LoadFromFile()
        {
          if (!File.Exists(filePath))
          {
            return;
          }

          string[] lines = File.ReadAllLines(filePath);

          for (int i = 0; i < lines.Length; i++)
          {
           string[] parts = lines[i].Split(',');

           Ingredient ing = new Ingredient();
           ing.Name = parts[0];
           ing.Quantity = int.Parse(parts[1]);

           ingredients.Add(ing);
          }
        }


    }
}