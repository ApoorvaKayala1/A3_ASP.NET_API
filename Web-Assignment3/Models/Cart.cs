using System.ComponentModel.DataAnnotations;

namespace Web_Assignment3.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public int User_Id { get; set; }

        public int Product_Id { get; set; }

        public int Quantity { get; set; }
    }
}
