using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Entities
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string TeamName { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false)]

        public byte[] Logo { get; set; } = Array.Empty<byte>(); // Przechowywanie obrazu jako tablica bajtów
        [Required(AllowEmptyStrings = false)]

        public string Address { get; set; } = string.Empty;
    }
}
