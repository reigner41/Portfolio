using PortfolioWithServer.Shared.Models;

public static class AchievementSeeder
{
    public static List<Achievement> GetAchievements()
    {
        return new List<Achievement>
        {
            new Achievement
            {
                Id = 1,
                Title = "Bachelor's Degree in Information Technology",
                Description = "AMA Computer College, 2017",
                ShortDescription = "Bacelors Degree in Information and Technology",
                DateAchieved = new DateTime(2017, 6, 1),
                Image = "ama.png",
                CertImage = "degree.jpg"
            },
            new Achievement
            {
                Id = 2,
                Title = "CS50x",
                Description = "HarvardX University",
                ShortDescription = "CS50x course offered by HarvardX.",
                DateAchieved = new DateTime(2023, 12, 4),
                Image = "HarvardX.png",
                CertImage = "HarvardXCert.png"
            },
            new Achievement
            {
                Id = 3,
                Title = "Top Rated Plus Freelancer",
                Description = "Upwork",
                ShortDescription = "Top Rated status on Upwork.",
                DateAchieved = new DateTime(2023, 12, 24),
                Image = "Upwork.png",
                CertImage = "Upwork.png"
            }
        };
    }
}
