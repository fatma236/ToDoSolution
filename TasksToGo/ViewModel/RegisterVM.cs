using System.ComponentModel.DataAnnotations;

namespace TasksToGo.ViewModel
{
    public class RegisterVM
    {
        [Required]
        [MaxLength(40, ErrorMessage = "Name should not be more than 40 charceter")]
        [Display(Name ="First Name")]
        public string fname { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Name should not be more than 40 charceter")]
        [Display(Name = "Last Name")]
        public string lname { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Name should not be more than 40 charceter")]
        [Display(Name = "Surname")]
        public string surName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }

    }
}
