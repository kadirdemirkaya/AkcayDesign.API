using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.DTOs.SignIn
{
    public class RegisterDto
    {

        [Required(ErrorMessage = "Name is required")]
        [StringLength(70, MinimumLength = 0, ErrorMessage = "Name length should be between 0 and 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [StringLength(100, MinimumLength = 0, ErrorMessage = "Surname length should be between 0 and 100 characters.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must be 10 digits.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        [StringLength(300, MinimumLength = 1, ErrorMessage = "Phone number must be 10 digits.")]
        public string? Message { get; set; }
    }
}
