using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Entities
{
    public class Aktualnosc
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime Date { get; set; }
    }
}
