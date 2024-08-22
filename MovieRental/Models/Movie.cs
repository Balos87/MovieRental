using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        [MaxLength(200)]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        public int ReleaseYear { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
