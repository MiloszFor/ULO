using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Entities
{
    public class TeamPoz
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? UserId { get; set; }
        public int TeamId { get; set; }
        public string? Position { get; set; }
        public char Status { get; set; }
    }
}
