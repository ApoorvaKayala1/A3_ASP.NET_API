using System.ComponentModel.DataAnnotations;

namespace Web_Assignment3.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public int User_Id { get; set; }
        public int Rating { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
    }
}
