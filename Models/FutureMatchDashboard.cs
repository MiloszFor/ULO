namespace ULO.UI.Models
{
    public class FutureMatchDashboard
    {
        public int Id { get; set; }
        public string? HostTeamName { get; set; }
        public byte[]? HostTeamLogo { get; set; }
        public string? GuestTeamName { get; set; }
        public byte[]? GuestTeamLogo { get; set; }
        public string? Address { get; set; }
        public DateTime MatchDate { get; set; }
    }
}
