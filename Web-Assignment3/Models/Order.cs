using System.ComponentModel.DataAnnotations;

namespace Web_Assignment3.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int User_Id { get; set; }

        public int Product_Id { get; set; }

        public int Quantity { get; set; }

        public decimal Total_Amount { get; set; }
    }
}
