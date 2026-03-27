using System;
using RestaurantApp.Models;
using RestaurantApp.Services;

namespace RestaurantApp
{
    class Program
    { 
        static void Main()
        {
            MenuService menuService = new MenuService();
            InventoryService inventory = new InventoryService();
            inventory.LoadFromFile();
            OrderService orderService = new OrderService();

            while (true)
            {
                Console.WriteLine("\n1. Add Stock");
                Console.WriteLine("2. Show Inventory");
                Console.WriteLine("3. Place Order");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter ingredient name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter quantity: ");
                    
                    int quantity;
                    while (true)
                    {
                        
                        if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid quantity. Please enter a valid integer.");
                        }
                    }

                    inventory.AddStock(name, quantity);
                    inventory.SaveToFile();

                }
                else if (choice == "2")
                {
                    inventory.ShowInventory();
                }
                else if (choice == "3")
                {
                    Order order = orderService.CreateOrder(inventory, menuService);
                    Console.WriteLine("Total Bill: " + order.CalculateTotal());
                    inventory.SaveToFile();
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}