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
            Position = "API Blockchain Integration Specialist (Part Time)",
            Responsibilities = new List<string>
            {
                "Pioneered a class library enabling backend software integration with Kaleido for efficient blockchain operations, including smart contract setups using pre-constructed Solidity codes.",
                "Utilized the class library for data burning and minting via a Blazor web application.",
                "Updated and maintained the Blazor software for carbon assets trading, enhancing user experience and functionality.",
                "Integrated Kaleido blockchain technology into the existing system, improving security and transparency in carbon trading operations.",
                "Implemented KYC (Know Your Customer) processes within the platform to ensure regulatory compliance in carbon trading.",
                "Developed and integrated blockchain solutions specifically tailored for carbon trading, optimizing transaction speed and reliability."
            },
            Technologies = new List<string> { ".Net Core", "Web3", "Clean Architecture", ".Net Blazor", "Solidity" }
        },
        new Experience
        {
            Company = "ReproTech",
            Location = "US (Remote)",
            Duration = "Dec 2022-2024",
            Position = "Acumatica Developer/Consultant (Project-Based)",
            Responsibilities = new List<string>
            {
                "Customized and expanded ERP software to accommodate the unique business models of diverse clients.",
                "Formulated API strategies to streamline B2B messaging processes.",
                "Introduced innovative screens and embedded business logic into the Acumatica framework.",
                "Facilitated B2B integrations, employing XML formats for robust business logic implementation.",
                "Seamlessly integrated Stripe and architected a Docusign integration for Acumatica ERP."
            },
            Technologies = new List<string> { "C#", "Restful API" }
        },
        new Experience
        {
            Company = "Block-Trust",
            Location = "Australia (Remote)",
            Duration = "Nov 2022-2023",
            Position = "Full-Stack Developer (Full Time)",
            Responsibilities = new List<string>
            {
                "Developed a .Net core API, integrating it with a Next.js frontend for enhanced CRUD operations and business logic.",
                "Established connections for minting components, facilitating blockchain wallet creation.",
                "Successfully migrated a legacy program to a modern, maintainable platform optimized for upgrades.",
                "Engineered APIs for seamless integration with customer CRM.",
                "Transitioned Web API projects to .NET core Clean Architecture.",
                "Designed a Blazor web application for frontend tasks, incorporating server-side handling via .Net 7.",
                "Implemented a Python-based AI model for Digi Art QR code generation.",
                "Developed an Azure Logic Application to manage workflow notifications via email."
            },
            Technologies = new List<string> { ".Net Core", "React", "Next.js", "Web3", "Clean Architecture", ".Net Blazor" }
        },
        new Experience
        {
            Company = "Asgard Alliance",
            Location = "Canada (Remote)",
            Duration = "Feb 2021 - 2023",
            Position = "Senior Software Developer (Full Time)",
            Responsibilities = new List<string>
            {
                "Customized and enhanced ERP software to align with diverse business models across multiple clients.",
                "Designed robust API processes for B2B messaging.",
                "Introduced new functional screens and integrated business logic into the Acumatica framework.",
                "Established B2B connectivity, employing XML for business logic creation.",
                "Seamlessly integrated both Twilio and Big Commerce with Acumatica ERP.",
                "Development of Asgard Label, a market-sold labeling package tailored for Acumatica."
            },
            Technologies = new List<string> { "C#", "Restful API" }
        },
        new Experience
        {
            Company = "Greatway Financial",
            Location = "Canada (Remote)",
            Duration = "Nov 2020 - 2022",
            Position = "Senior Software Developer (Full-Time)",
            Responsibilities = new List<string>
            {
                "Spearheaded the development of the front-end interface of Smart Mortgage using React.js.",
                "Designed a robust API for Smart Mortgage utilizing Node.js.",
                "Architected the backend infrastructure of Smart Mortgage with MySQL.",
                "Successfully hosted the comprehensive Smart Mortgage calculator on CentOS.",
                "Created 'My Online Office,' enabling advisors to efficiently track business metrics and earnings.",
                "Led backend development for all proprietary web applications."
            },
            Technologies = new List<string> { "React.js", "Node.js", "Laravel", "PHP", "JavaScript", "Restful API" }
        },
        new Experience
        {
            Company = "MomentTrack",
            Location = "UTAH (Remote)",
            Duration = "January 2018 - 2023",
            Position = "Project Manager/Developer (Part Time)",
            Responsibilities = new List<string>
            {
                "Engineered a versatile API for a QR code system, facilitating seamless data transfers from mobile apps to diverse ERP systems.",
                "Developed a time-logging API for client websites using RESTful protocols.",
                "Created AWS Lambda functions in Python to capture webhook and JSON data, ensuring smooth ERP integrations.",
                "Launched 'Learning in the Moment,' a video tutorial platform enabling users to upload, view, and earn achievements for comprehended content.",
                "Led the design and launch of the MomentTrack main landing page.",
                "Deployed mobile apps with capabilities to scan QR codes and Data Matrix, interfacing directly with backend databases for real-time updates."
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
                "Architected a production scheduling tool with barcode scanner functionality tailored for the PUMA factory in Vietnam, fully integrated with Acumatica.",
                "Executed specialized Acumatica customizations to meet the distinct requirements of 11FTC Novaliches.",
                "Innovated by launching Cloudian's maiden API, establishing a seamless bridge between Acumatica and Lazada.",
                "Led the development of the Cloudian Payroll System, leveraging Python Flask and cutting-edge No-SQL database infrastructure."
            },
            Technologies = new List<string> { "C#", "Restful API", "Web Services", "XML", "Acumatica BQL" }
        },
        new Experience
        {
            Company = "Micrologic Systems Inc",
            Location = "Philippines",
            Duration = "Sept 2018 – May 2019",
            Position = "Software Engineer I (Full-Time)",
            Responsibilities = new List<string>
            {
                "Pioneered the development of machine learning neural networks for robust image and object classification, leveraging device cameras.",
                "Contributed to the creation of a Universal Payment System, drawing parallels with industry giants like Paymaya and Gcash.",
                "Appointed as the network and server security administrator for the Department of Science and Technology (DOST) government department.",
                "Designed and implemented a GPS tracking system for the Panay Railroad, enhancing the monitoring of bus trains in the Visayas region, Philippines."
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
                "Developed a desktop application tailored for the generation of transaction and sales reports, utilizing .Net and MSSQL.",
                "Entrusted with the periodic updates and maintenance of the Toll Booth Software.",
                "Spearheaded the creation of software designed to facilitate seamless data transfer from local servers, employing Perl.",
                "Innovated automated card encoding mechanisms, minimizing manual intervention and optimizing efficiency."
            },
            Technologies = new List<string> { ".Net", "Perl", "Android Studio", "Python" }
            }
        };
    }
}