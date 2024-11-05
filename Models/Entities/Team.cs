using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Entities
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string? TeamName { get; set; }
        public String? InstaUrl { get; set; }
        public string? Address { get; set; }
        public int OwnerId { get; set; }
        public char Status { get; set; }
        public byte[]? Logo { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
