using System.ComponentModel.DataAnnotations;

namespace TasksToGo.ViewModel
{
    public class RegisterVM
    {
        [Required]
        [MaxLength(40, ErrorMessage = "Name should not be more than 40 charceter")]
        public string fname { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Name should not be more than 40 charceter")]
        public string lname { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Name should not be more than 40 charceter")]
        public string surName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
       
        public string PasswordConfirm { get; set; }

    }
}
