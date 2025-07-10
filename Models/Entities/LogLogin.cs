using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Entities
{
    public class LogLogin
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
    }
}
