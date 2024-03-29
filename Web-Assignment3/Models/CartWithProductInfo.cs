namespace Web_Assignment3.Models
{
    public class CartWithProductInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal ProductPricing { get; set; }
    }
}
