using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieRental.Models
{
    public class Rental
    {
        [Key]
        public int RentalId { get; set; }

        [ForeignKey("User")]
        public int FK_UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("Movie")]
        public int FK_MovieId { get; set; }

        public Movie Movie { get; set; }

        [Required]
        public DateTime LoanDate { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}
