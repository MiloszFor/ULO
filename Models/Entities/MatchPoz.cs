using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Entities
{
    public class MatchPoz
    {
        [Key]
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int? Score1Value { get; set; }
        public int? Score2Value { get; set; }

    }
}
