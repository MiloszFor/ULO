using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models
{
    public class AddTeamPozDto
    {
        [Required(AllowEmptyStrings = false)]
        public string? FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string? LastName { get; set; }
        public int? UserId { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string? Position { get; set; }
    }
}
