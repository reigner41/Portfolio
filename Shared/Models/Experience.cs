namespace PortfolioWithServer.Shared.Models
{
    public class Experience
    {
        public string? Company { get; set; }
        public string? Position { get; set; }
        public string? Duration { get; set; }
        public string? Location { get; set; }
        public List<string>? Responsibilities { get; set; }
        public List<string>? Technologies { get; set; }
    }
}