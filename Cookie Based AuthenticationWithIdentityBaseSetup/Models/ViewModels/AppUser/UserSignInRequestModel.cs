using System.ComponentModel.DataAnnotations;

namespace Cookie_Based_AuthenticationWithIdenty.Models.ViewModels.AppUser
{
    public class UserSignInRequestModel
    {
        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(3, ErrorMessage = "Min 3 Character")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }  
        public string? ReturnUrl { get; set; }
    }
}
