using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Entities
{
    public class Statute
    {
        [Key]
        public int Id { get; set; }
        public string? Rules { get; set; }
    }
}
