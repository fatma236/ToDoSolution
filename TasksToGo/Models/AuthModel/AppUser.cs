using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TasksToGo.Models.AuthModel
{
    public class AppUser : IdentityUser
    {
       
        
        [Required]
        [MaxLength(50)]
        public string Fname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Lname { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public virtual ICollection<TodoTask> TodoTasks { get; set; }
    }
}
