using System.ComponentModel.DataAnnotations;

namespace TasksToGo.ViewModel
{
    public class LoginMV
    {
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        public bool? RememberMe { get; set; } = false;

    }
}
