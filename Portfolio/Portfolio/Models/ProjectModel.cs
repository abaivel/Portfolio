namespace Portfolio.Models
{
    public class ProjectModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string? Url { get; set; }
        public string? GithubUrl { get; set; }
        public ProjectModel(string name, string description, string language, string? url, string? githubUrl)
        {
            Name = name;
            Description = description;
            Language = language;
            Url = url;
            GithubUrl = githubUrl;
        }
    }
}
