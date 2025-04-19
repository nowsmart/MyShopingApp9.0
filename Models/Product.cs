using System.ComponentModel.DataAnnotations;

namespace MyShopingApp9._0.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? imageUrl { get; set; }
    }
}
