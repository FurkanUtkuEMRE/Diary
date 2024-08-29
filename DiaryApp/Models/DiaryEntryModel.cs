using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntryModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "You need to give the entry a title.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Your title must be between 3 and 50 characters!")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "You need to write some content for the entry.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Your title must be between 5 and 50 characters!")]
        public required string Content { get; set; }

        [Required(ErrorMessage = "You need to pick a date for your entry.")]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
