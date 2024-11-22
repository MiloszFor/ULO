using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Entities
{
    public class GoalsMatch
    {
        [Key]
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Goals { get; set; }
        public int TeamId { get; set; }
        public int MatchId { get; set; }
    }
}
