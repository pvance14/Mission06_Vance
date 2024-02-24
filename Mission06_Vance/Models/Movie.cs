using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Vance.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Sorry, you need to enter the title of the Movie!")]
        public string Title { get; set;}

        [Required(ErrorMessage = "Enter what year the movie was released")]
        [Range(1888, int.MaxValue, ErrorMessage = "The year must be greater than or equal to 1888.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }


    }
}
