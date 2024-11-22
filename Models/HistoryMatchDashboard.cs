namespace ULO.UI.Models
{
    public class HistoryMatchDashboard
    {
        public int Id { get; set; }
        public string? HostTeamName { get; set; }
        public byte[]? HostTeamLogo { get; set; }
        public string? GuestTeamName { get; set; }
        public byte[]? GuestTeamLogo { get; set; }
        public DateTime MatchDate { get; set; }
        public int? Score1Value { get; set; }
        public int? Score2Value { get; set; }
    }
}
