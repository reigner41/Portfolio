using PortfolioWithServer.Shared.Models;

public static class ExperienceSeeder
{
    public static List<Experience> GetExperiences()
    {
        return new List<Experience>
        {
            new Experience
            {
                Company = "Carbon Assets Solutions",
                Location = "Australia (Remote)",
                Duration = "Nov 2022-2024",
                Position = "API Integration Specialist (Contract)",
                Responsibilities = new List<string>
                {
                    "Developed a class library to integrate backend software with Kaleido, streamlining blockchain operations and reducing setup time by 30%.",
                    "Enabled smart contract setups using pre-constructed Solidity codes, increasing deployment efficiency by 25%.",
                    "Integrated data burning and minting processes through a Blazor web application, improving system scalability and transaction handling."
                },
                Technologies = new List<string> { ".Net Core", "Web3", "Clean Architecture", "Blazor" }
            },
            new Experience
            {
                Company = "ReproTech",
                Location = "US (Remote)",
                Duration = "Dec 2022-2024",
                Position = "Acumatica Developer/Consultant (Contract)",
                Responsibilities = new List<string>
                {
                    "Customized and enhanced ERP software to support diverse client business models, improving workflow efficiency by 20%.",
                    "Designed and implemented API strategies that streamlined B2B messaging, reducing data transfer errors by 25%.",
                    "Developed innovative screens and embedded business logic within the Acumatica framework, increasing system usability and functionality.",
                    "Spearheaded B2B integrations using XML, ensuring robust business logic implementation across multiple platforms.",
                    "Seamlessly integrated Stripe and designed a Docusign integration for Acumatica, optimizing payment and contract processes for clients."
                },
                Technologies = new List<string> { "C#", "Restful API" }
            },
            new Experience
            {
                Company = "Block-Trust",
                Location = "Australia (Remote)",
                Duration = "Nov 2022-2023",
                Position = "Full-Stack Developer (Contract)",
                Responsibilities = new List<string>
                {
                    "Developed a .Net Core API integrated with a Next.js frontend, improving CRUD operation efficiency by 30% and optimizing business logic handling.",
                    "Established blockchain wallet functionality by integrating minting components, enhancing the platform's security and ease of use.",
                    "Migrated legacy programs to a modern, maintainable platform, reducing system maintenance costs by 20% and improving upgradeability.",
                    "Engineered APIs for seamless CRM integration, resulting in a 25% improvement in data synchronization and customer management.",
                    "Transitioned Web API projects to .NET Core Clean Architecture, enhancing code maintainability and reducing technical debt.",
                    "Designed a Blazor web application for frontend tasks, incorporating server-side handling via .Net 7, increasing frontend performance by 15%.",
                    "Implemented a Python-based AI model for Digi Art QR code generation, adding unique, AI-driven functionality to the platform.",
                    "Developed an Azure Logic Application for automated workflow notifications, improving communication efficiency and reducing manual intervention."
                },
                Technologies = new List<string> { ".Net Core", "React", "Next.js", "Web3", "Clean Architecture", "Blazor", "Python" }
            },
            new Experience
            {
                Company = "Asgard Alliance",
                Location = "Canada (Remote)",
                Duration = "Feb 2021 - 2023",
                Position = "Senior Software Developer (Contract)",
                Responsibilities = new List<string>
                {
                    "Customized and enhanced ERP software for multiple clients, optimizing workflows and improving system adaptability to diverse business models by 25%.",
                    "Designed and implemented robust API processes for B2B messaging, reducing communication errors by 30% and improving data transfer efficiency.",
                    "Developed new functional screens and integrated complex business logic within the Acumatica framework, enhancing user experience and operational capabilities.",
                    "Established B2B connectivity using XML, streamlining business logic creation and ensuring smooth integration across platforms.",
                    "Seamlessly integrated Twilio and BigCommerce with Acumatica ERP, improving communication automation and e-commerce functionality.",
                    "Led the development of Asgard Label, a market-ready labeling package for Acumatica, generating additional revenue streams for the company."
                },
                Technologies = new List<string> { "C#", "Restful API" }
            },
            new Experience
            {
                Company = "Greatway Financial",
                Location = "Canada (Remote)",
                Duration = "Nov 2020 - 2022",
                Position = "Senior Software Developer (Contract)",
                Responsibilities = new List<string>
                {
                    "Spearheaded the development of the Smart Mortgage front-end using React.js, improving user experience and reducing load times by 20%.",
                    "Designed and implemented a robust API for Smart Mortgage using Node.js, enabling secure and efficient data processing, reducing application processing time by 25%.",
                    "Architected the backend infrastructure for Smart Mortgage with MySQL, ensuring data integrity and scalability for future enhancements.",
                    "Successfully deployed the Smart Mortgage calculator on CentOS, resulting in a 15% improvement in server performance and uptime.",
                    "Developed the 'My Online Office' platform, empowering financial advisors to track business metrics and earnings."
                },
                Technologies = new List<string> { "React.js", "Node.js", "Laravel", "PHP", "JavaScript", "Restful API" }
            },
            new Experience
            {
                Company = "MomentTrack",
                Location = "UTAH (Remote)",
                Duration = "January 2018 - 2023",
                Position = "Project Manager/Developer (Part-Time)",
                Responsibilities = new List<string>
                {
                    "Engineered a versatile API for a QR code system, enabling seamless data transfers between mobile apps and diverse ERP systems, improving data accuracy and synchronization by 30%.",
                    "Developed a time-logging API for client websites using RESTful protocols, streamlining time management processes and enhancing user productivity.",
                    "Created AWS Lambda functions in Python to capture webhook and JSON data, ensuring smooth ERP integration and reducing data processing time by 20%.",
                    "Launched 'Learning in the Moment', a video tutorial platform, which increased user engagement by 40% by enabling users to upload, view, and earn achievements for completed content."
                },
                Technologies = new List<string> { "React.js", "Node.js", "Python", "AWS Lambda", "Restful API" }
            },
            new Experience
            {
                Company = "Cloudian",
                Location = "Philippines",
                Duration = "May 2019 - November 2020",
                Position = "Software Developer (Full-Time)",
                Responsibilities = new List<string>
                {
                    "Architected a production scheduling tool with barcode scanner functionality for the PUMA factory in Vietnam, fully integrated with Acumatica, resulting in a 20% increase in operational efficiency.",
                    "Customized Acumatica to meet the specific needs of 11FTC Novaliches, improving process automation and reducing manual errors by 25%.",
                    "Launched Cloudian's first API, establishing seamless integration between Acumatica and Lazada, reducing data synchronization time by 30%.",
                    "Led the development of the Cloudian Payroll System, utilizing Python Flask and a NoSQL database infrastructure, which improved payroll processing speed by 40% and enhanced data accuracy."
                },
                Technologies = new List<string> { "C#", "RESTful API", "Web Services", "XML", "Acumatica BQL", "Python Flask", "NoSQL" }
            },
            new Experience
            {
                Company = "Micrologic Systems Inc",
                Location = "Philippines",
                Duration = "Sept 2018 – May 2019",
                Position = "Software Engineer I (Full-Time)",
                Responsibilities = new List<string>
                {
                    "Pioneered the development of machine learning neural networks for image and object classification, improving device camera accuracy and efficiency in processing by 35%.",
                    "Contributed to the development of a Universal Payment System, modeled after industry giants like Paymaya and Gcash, streamlining mobile payment processes and increasing system reliability by 25%.",
                    "Appointed as the Network and Server Security Administrator for the Department of Science and Technology (DOST), enhancing overall system security and reducing vulnerabilities by 40%.",
                    "Designed and implemented a GPS tracking system for the Panay Railroad, improving bus train monitoring and reducing delays in the Visayas region by 15%."
                },
                Technologies = new List<string> { ".Net", "Perl", "Android Studio", "Python" }
            },
            new Experience
            {
                Company = "Tarlac Pangasinan La-Union Expressway",
                Location = "Philippines",
                Duration = "Aug 2017 - 2018",
                Position = "System Programmer (Full-Time)",
                Responsibilities = new List<string>
                {
                    "Developed a desktop application for generating transaction and sales reports, utilizing .Net and MSSQL, improving data accuracy and report generation speed by 20%.",
                    "Led periodic updates and maintenance for the Toll Booth Software, ensuring smooth operation and reducing system downtime by 15%.",
                    "Spearheaded the development of software to facilitate seamless data transfer from local servers using Perl, enhancing data transfer efficiency by 30%.",
                    "Innovated automated card encoding mechanisms, reducing manual intervention and optimizing operational efficiency by 25%."
                },
                Technologies = new List<string> { ".Net", "Perl", "MSSQL", "Android Studio", "Python" }
            }
        };
    }
}
