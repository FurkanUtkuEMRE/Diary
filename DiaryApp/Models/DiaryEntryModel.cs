using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntryModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Content { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
