using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TasksToGo.Models.AuthModel
{
    public class AppUser : IdentityUser
    {
       
        
        [Required]
        [MaxLength(50)]
        public string fname { get; set; }
        [Required]
        [MaxLength(50)]
        public string lname { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public virtual ICollection<TodoTask> TodoTasks { get; set; }
    }
}
