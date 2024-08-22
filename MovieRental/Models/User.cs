using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } 

        [Required]
        public string Email { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
