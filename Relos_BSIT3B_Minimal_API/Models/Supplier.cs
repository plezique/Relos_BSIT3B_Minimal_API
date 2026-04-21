using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Relos_BSIT3B_Minimal_API.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? ContactEmail { get; set; }

        [MaxLength(20)]
        public string? Phone { get; set; }
        // Navigation property — one Supplier has many Products
        public ICollection<Product>? Products { get; set; }
    }
}
