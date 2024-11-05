using System.ComponentModel.DataAnnotations;

namespace ULO.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public required string Login { get; set; }
        public required string Email { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Password { get; set; }
        public required string Rank { get; set; }
    }
}
