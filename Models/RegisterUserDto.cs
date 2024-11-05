using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models
{
    public class RegisterUserDto
    {
        [Required(AllowEmptyStrings = false)]
        public string Login { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string ConfirmPassword { get; set; }
    }
}
