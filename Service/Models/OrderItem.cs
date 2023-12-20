namespace Service.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Order order { get; set; }
        public Product product { get; set; }

        
    }
}
