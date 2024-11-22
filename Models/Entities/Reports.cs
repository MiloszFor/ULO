using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Entities
{
    public class Reports
    {
        [Key]
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public string? ReportText { get; set; }
    }
}
