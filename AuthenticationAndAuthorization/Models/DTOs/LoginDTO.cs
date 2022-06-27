using System.ComponentModel.DataAnnotations;

namespace AuthenticationAndAuthorization.Models.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Username alani zorunludur")]
        [Display(Name = "User Nanem")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password alani zorunludur")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
