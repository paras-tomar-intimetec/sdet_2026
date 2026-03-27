using System.Collections.Generic;

namespace RestaurantApp.Models
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Dictionary<string, int> Ingredients { get; set; } = new Dictionary<string, int>();
    }
}