using System.ComponentModel.DataAnnotations;

namespace Web_Assignment3.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public decimal Pricing { get; set; }

        public decimal Shipping_Cost { get; set; }

    }
}
