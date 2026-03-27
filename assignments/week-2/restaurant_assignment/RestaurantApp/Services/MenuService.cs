using System.Collections.Generic;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class MenuService
    {
        public List<MenuItem> menu = new List<MenuItem>();

        public MenuService()
        {
            // Hardcoded menu (simple rakh rahe hain)
            MenuItem pizza = new MenuItem();

            pizza.Name = "pizza";
            pizza.Price = 200;
            
            pizza.Ingredients.Add("tomato", 2);
            pizza.Ingredients.Add("cheese", 1);

            menu.Add(pizza);
        }

        public MenuItem GetItem(string name)
        {
            name = name.ToLower();
            
            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Name.ToLower() == name.ToLower())
                {
                    return menu[i];
                }
            }
            return null;
        }
    }
}