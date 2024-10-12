namespace PortfolioWithServer.Shared.Models
{
    public class Skill
    {
        public string Name { get; set; } = string.Empty;
        public int Proficiency { get; set; }
        public string ImageName { get; set; } = string.Empty;
        public string GetImagePath() => $"/Images/Skills/{ImageName}";
    }
}
