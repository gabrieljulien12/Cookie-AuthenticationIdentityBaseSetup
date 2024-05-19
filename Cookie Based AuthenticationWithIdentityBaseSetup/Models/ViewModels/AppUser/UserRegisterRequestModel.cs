using System.ComponentModel.DataAnnotations;

namespace Cookie_Based_AuthenticationWithIdenty.Models.ViewModels.AppUser
{
    public class UserRegisterRequestModel
    {
        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(3,ErrorMessage ="Min 3 Character")]
        public string Password { get; set; }

        [Compare ("Password",ErrorMessage ="Dont same Password")]
        public string ConfirmPassword { get; set; }
    }
}
