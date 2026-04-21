using System.ComponentModel.DataAnnotations;

namespace Relos_BSIT3B_Minimal_API.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
