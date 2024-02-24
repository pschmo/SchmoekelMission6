using System.ComponentModel.DataAnnotations;

namespace SchmoekelMission6.Models
{
    public class Submission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

       
        public string Genre { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string ReleaseYear { get; set; }

        [Required]
        public MovieRatingEnum Rating { get; set; }

        [Required]
        public EditedEnum Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
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
