using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace Relos_BSIT3B_Minimal_API.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; }
        // Navigation property — one Category has many Products
        public ICollection<Product>? Products { get; set; }
    }
}