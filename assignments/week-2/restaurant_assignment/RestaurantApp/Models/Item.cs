namespace RestaurantApp.Models
{
    public class Item
    {
        public string Name { get; set;}
        public double Price { get; set;}
        public int Quantity { get; set;}

        public double GetTotal()
        {
            return Price * Quantity;
        }
    }
}