using System.Net.NetworkInformation;
using Portfolio.Enums;

namespace Portfolio.Models
{
    public class ProjectModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Introduction { get; set; }
        public List<string> Paragraphes { get; set; } = new List<string>();
        public List<string?> Images { get; set; } = new List<string?>();
        public string Language { get; set; }
        public string? Url { get; set; }
        public string? GithubUrl { get; set; }
        public int NbPeople { get; set; } = 1;
        public int Year { get; set; }
        public TypeProjectEnum TypeProjectEnum { get; set; }
        public TypeSoftwareEnum TypeSoftwareEnum { get; set; }
        public ProjectModel(string name, string intro, string language, string? url, string? githubUrl, int nbPeople, int year, TypeProjectEnum typeProjectEnum, TypeSoftwareEnum typeSoftwareEnum)
        {
            Name = name;
            Introduction= intro;
            Language = language;
            Url = url;
            GithubUrl = githubUrl;
            NbPeople = nbPeople;
            Year = year;
            TypeProjectEnum = typeProjectEnum;
            TypeSoftwareEnum = typeSoftwareEnum;
        }
    }
}
