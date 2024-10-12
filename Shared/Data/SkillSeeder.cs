using PortfolioWithServer.Shared.Models;

public static class SkillSeeder
{
    public static List<Skill> GetSkills()
    {
        return new List<Skill>
        {
            new Skill
            {
                Name = ".NET",
                Proficiency = 90,
                ImageName = "dotnet.png"
            },
            new Skill
            {
                Name = "C#",
                Proficiency = 90,
                ImageName = "csharp.png"
            },
            new Skill
            {
                Name = "Blazor",
                Proficiency = 85,
                ImageName = "blazor.png"
            },
            new Skill
            {
                Name = "React.js",
                Proficiency = 80,
                ImageName = "react.png"
            },
            new Skill
            {
                Name = "Node.js",
                Proficiency = 80,
                ImageName = "nodejs.png"
            },
            new Skill
            {
                Name = "RESTful API",
                Proficiency = 90,
                ImageName = "restapi.png"
            },
            new Skill
            {
                Name = "Python",
                Proficiency = 75,
                ImageName = "python.png"
            },
            new Skill
            {
                Name = "AWS",
                Proficiency = 70,
                ImageName = "aws.png"
            },
            new Skill
            {
                Name = "Azure",
                Proficiency = 70,
                ImageName = "azure.png"
            },
            new Skill
            {
                Name = "Acumatica",
                Proficiency = 85,
                ImageName = "acumatica.png"
            },
            new Skill
            {
                Name = "Laravel",
                Proficiency = 70,
                ImageName = "laravel.png"
            },
            new Skill
            {
                Name = "PHP",
                Proficiency = 70,
                ImageName = "php.png"
            },
            new Skill
            {
                Name = "JavaScript",
                Proficiency = 85,
                ImageName = "javascript.png"
            },
            new Skill
            {
                Name = "Machine Learning",
                Proficiency = 65,
                ImageName = "tensorflow.png"
            }
        };
    }
}
