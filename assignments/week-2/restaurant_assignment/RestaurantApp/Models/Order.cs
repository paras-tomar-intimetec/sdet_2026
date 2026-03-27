using System.Collections.Generic;
using System.Net.ServerSentEvents;

namespace RestaurantApp.Models
{
    public class Order
    {
        public List<Item> Items { get; set; } = new List<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public double CalculateTotal()
        {
          double total = 0;

          for (int i = 0; i < Items.Count; i++)
          {
            total += Items[i].GetTotal();
          }

           double tax = total * 0.18;   // 18% GST
           return total + tax;
        }
    }
}