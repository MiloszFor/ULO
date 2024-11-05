using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models
{
    public class LoginUserDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage ="Please provide User Name")]
        public string? Login { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide User Password")]
        public string? Password { get; set; }
    }
}
