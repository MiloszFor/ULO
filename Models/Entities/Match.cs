using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Entities
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public int HostTeamId { get; set; }
        public int GuestTeamId { get; set; }
        public string? Place { get; set; }
        public DateTime? MatchDate { get; set; }
        public char? Status { get; set; }
    }
}
