using Portfolio.Models;
using Portfolio.Pages;

namespace Portfolio.Services
{
    public class ProjectService
    {  
        public static List<ProjectModel> Projects { get; set; } = new List<ProjectModel>();
        public static void createProjects()
        {
            /*
             PORTFOLIO,
		GAME4X,
		HEDGESHOP,
		LBAPROPRETE_WEBSITE,
		LBAPROPRETE_APP,
		JEUNES64,
		LEVEL1,
             */
            Projects.Add(new ProjectModel("Portfolio", "My most recent project is this portfolio.\n\n" +
                "It's made with the framework Blazor, a ASP.NET Core framework. That framework allows to integrate C# in HTML files. I also use the library MudBlazor which propose ready-to-use components.", 
                "Blazor", null, "https://github.com/abaivel/Portfolio"));

            Projects.Add(new ProjectModel("4X Game", "",
                "Java, JEE, JPA, Servlet, JSP", "/4xgame", "https://github.com/abaivel/Projet_JEE"));

            Projects.Add(new ProjectModel("HedgeShop", "",
                "React.js, Django", "/hedgeshop", "https://github.com/UnderSkyle/ProjetWebING1"));

            Projects.Add(new ProjectModel("LBA Proprete Website", "",
                "HTML, CSS, PHP", "https://baivel.com/", null));

            Projects.Add(new ProjectModel("LBA Proprete Android App", "",
                "Java, Kotlin", "https://baivel.com/", null));

            Projects.Add(new ProjectModel("Jeunes 6.4", "",
                "HTML, CSS, PHP", "/jeunes64", "https://github.com/max91p/projet_Jeunes_6.4"));

            Projects.Add(new ProjectModel("Level 1", "",
                "Java, javafx", null, "https://github.com/abaivel/projet_javafx"));

        }
        public static List<ProjectModel> getProjects()
        {
            if (Projects.Count == 0)
            {
                createProjects();
            }
            return Projects;
        }
    }
}
