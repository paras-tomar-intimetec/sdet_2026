using System;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class OrderService
    {
        public Order CreateOrder(InventoryService inventory, MenuService menuService)
        {
            Order order = new Order();

            while (true)
            {
                Console.WriteLine("Enter item name (or 'exit'): ");
                
                string name = Console.ReadLine();
                name = name.ToLower();

                if (name.ToLower() == "exit")
                {
                    break;
                }
                //Console.Write("Enter price: ");
                //double price = double.Parse(Console.ReadLine());
                double price;
                while (true)
                {
                    Console.Write("Enter price: ");
                    if (double.TryParse(Console.ReadLine(), out price) && price >= 0)
                    {
                        break;
                    }                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid price.");
                    }
                }

                //Console.Write("Enter quantity: ");
                //int quantity = int.Parse(Console.ReadLine());
                int quantity;
                while (true)
                {
                    Console.Write("Enter quantity: ");
                    if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity. Please enter a valid integer.");
                    }
                }

                Item item = new Item
                {
                    Name = name,
                    Price = price,
                    Quantity = quantity
                };
                order.AddItem(item);


                //inventory update 
                MenuItem menuItem = menuService.GetItem(name);

                 if (menuItem != null)
                 {
                   foreach (var ing in menuItem.Ingredients)
                   {
                     string ingredientName = ing.Key;
                     int requiredQty = ing.Value * quantity;

                     inventory.ReduceStock(ingredientName, requiredQty);
                   }
                 }
                 else
                 {
                  Console.WriteLine("Item not found in menu");
                 }
            }
            return order;
        }
    }
}