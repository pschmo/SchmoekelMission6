using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchmoekelMission6.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public MovieRatingEnum Rating { get; set; }

        [Required]
        public EditedEnum Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string CopiedToPlex { get; set; }

        public string Notes { get; set; }  // Added Notes property
    }


    public enum MovieRatingEnum
    {
        G,
        PG,
        PG13,
        R
    }

    public enum EditedEnum
    {
        Yes,
        No
    }
}