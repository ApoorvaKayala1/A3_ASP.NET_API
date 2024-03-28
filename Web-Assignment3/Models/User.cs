using System.ComponentModel.DataAnnotations;

namespace Web_Assignment3.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [Required]
        public string Username { get; set; }

        public string Purchase_History { get; set; }

        public string Shipping_Address { get; set; }

        public string Contact { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }

        public string Zip_Code { get; set; }
    }
}
