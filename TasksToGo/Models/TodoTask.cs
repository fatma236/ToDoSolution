using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TasksToGo.Models.AuthModel;

namespace TasksToGo.Models
{
    public class TodoTask
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool? IsCompeleted { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(taskCategory))]
        public int TaskCategoryId { get; set; }

        [ForeignKey(nameof(AppUser))]
        
        public TaskCategory? taskCategory { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser? User { get; set; }
    }
}
