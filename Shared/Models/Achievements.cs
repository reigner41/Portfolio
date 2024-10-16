public class Achievement
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ShortDescription { get; set; }
    public DateTime? DateAchieved { get; set; }
    public string? Image { get; set; }
    public string GetImagePath() => $"/Images/Achievements/{Image}";
    public string? CertImage { get; set; }
    public string GetCertImagePath() => $"/Images/Achievements/{CertImage}";
}
