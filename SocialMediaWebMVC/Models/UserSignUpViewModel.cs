using System.ComponentModel.DataAnnotations;

namespace SocialMediaWebMVC.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter your name.")]
        public String Name { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Please enter your surname.")]
        public String Surname { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please enter your username.")]
        public String Username { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Please enter your mail.")]
        public String Mail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter your password.")]
        public String Password { get; set; }

        [Display(Name = "Birthday")]
        [Required(ErrorMessage = "Please enter your birthday.")]
        public String Birthday { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Please enter your gender.")]
        public String Gender { get; set; }
    }
}
