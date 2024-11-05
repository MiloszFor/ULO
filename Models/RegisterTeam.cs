using System.ComponentModel.DataAnnotations;
using ULO.UI.Models.Validation;

namespace ULO.UI.Models
{
    public class RegisterTeam
    {
        [Required(AllowEmptyStrings = false)]
        public string? TeamName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string? InstaUrl { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string? Address { get; set; }
        [MustBeTrue(ErrorMessage = "Musisz zaakceptować regulamin.")]
        public bool AcceptTerms { get; set; }
        [Required(AllowEmptyStrings = true)]
        public byte[]? Logo { get; set; }
    }
}
