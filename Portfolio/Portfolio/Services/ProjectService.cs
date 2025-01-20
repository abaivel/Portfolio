using Portfolio.Models;
using Portfolio.Pages;

namespace Portfolio.Services
{
    public class ProjectService
    {  
        public static List<ProjectModel> Projects { get; set; } = new List<ProjectModel>();
        public static void createProjects()
        {
            #region Portfolio
            Projects.Add(new ProjectModel("Portfolio", "My most recent project is this portfolio.\n" +
                "It's made with the framework Blazor, a ASP.NET Core framework. That framework allows to integrate C# in HTML files. I also use the library MudBlazor which propose ready-to-use components.", 
                "Blazor", null, "https://github.com/abaivel/Portfolio", 1, 2025, Enums.TypeProjectEnum.PERSO));
            #endregion

            #region 4XGame
            ProjectModel p4XGame = new ProjectModel("4X Game", "This project is a 4X Game, which is a strategy game in which the users' actions can be summarize by the '4X', eXploration, eXpansion, eXploitation et eXtermination." +
                "The purpose of this project was te program a simple game using JEE, with servlets, JSPs and JPA and by respecting a MVC architecture.",
                "Java, JEE, JPA, Servlet, JSP", null, "https://github.com/abaivel/Projet_JEE", 4, 2025, Enums.TypeProjectEnum.SCHOOL);

            p4XGame.Paragraphes.Add("This project is a 4X Game, which is a strategy game in which the users' actions can be summarize by the '4X', eXploration, eXpansion, eXploitation et eXtermination. " +
                "The purpose of this project was te program a simple game using JEE, with servlets, JSPs and JPA and by respecting a MVC architecture.");
            p4XGame.Images.Add("images/data-5606639_1280.jpg");

            p4XGame.Paragraphes.Add("This project is a 4X Game, which is a strategy game in which the users' actions can be summarize by the '4X', eXploration, eXpansion, eXploitation et eXtermination. " +
                "The purpose of this project was te program a simple game using JEE, with servlets, JSPs and JPA and by respecting a MVC architecture.");
            p4XGame.Images.Add("images/data-5606639_1280.jpg");

            Projects.Add(p4XGame);
            #endregion

            #region Hedgeshop
            ProjectModel pHedgeShop = new ProjectModel("HedgeShop", "This project is a sales website. We had to choose the objects to sell and one of my teammate adores hedgehog so we did a website to sell objects for hedgehogs.\n\n",
                "React.js, Django", null, "https://github.com/UnderSkyle/ProjetWebING1", 3, 2024, Enums.TypeProjectEnum.SCHOOL);

            Projects.Add(pHedgeShop);
            #endregion

            #region Level1
            ProjectModel pLevel1 = new ProjectModel("Level 1", "",
                "Java, javafx", null, "https://github.com/abaivel/projet_javafx", 2, 2024, Enums.TypeProjectEnum.SCHOOL);

            Projects.Add(pLevel1);
            #endregion

            #region LBAPropreteWebsite
            ProjectModel pLBAWeb = new ProjectModel("LBA Proprete Website", "",
                "HTML, CSS, PHP", "https://baivel.com/", null, 1, 2023, Enums.TypeProjectEnum.WORK);

            Projects.Add(pLBAWeb);
            #endregion

            #region LBAPropreteAndroidApp
            ProjectModel pLBAAndroid = new ProjectModel("LBA Proprete Android App", "",
                "Java, Kotlin", null, null, 1, 2022, Enums.TypeProjectEnum.WORK);

            Projects.Add(pLBAAndroid);
            #endregion

            #region Jeunes64
            ProjectModel pJeunes64 = new ProjectModel("Jeunes 6.4", "",
                "HTML, CSS, PHP", "/jeunes64", "https://github.com/max91p/projet_Jeunes_6.4", 4, 2023, Enums.TypeProjectEnum.SCHOOL);

            Projects.Add(pJeunes64);
            #endregion

            #region CYmeteo
            ProjectModel pCYMeteo = new ProjectModel("CY meteo", "",
                "C, Shell", null, "https://github.com/abaivel/projet_meteo", 1, 2023, Enums.TypeProjectEnum.SCHOOL);

            Projects.Add(pCYMeteo);
            #endregion

            #region Tetris
            ProjectModel pTetris = new ProjectModel("Tetris", "",
                "C", null, "https://github.com/abaivel/projet_tetris", 1, 2022, Enums.TypeProjectEnum.SCHOOL);

            Projects.Add(pTetris);
            #endregion

            #region Bujo
            ProjectModel pBujo = new ProjectModel("Bujo", "",
                "Java, Kotlin", null, null, 1, 2022, Enums.TypeProjectEnum.PERSO);

            Projects.Add(pBujo);
            #endregion

            #region EcoBasket
            ProjectModel pEcoBasket = new ProjectModel("Eco-Basket", "",
                "Kotlin", null, null, 1, 2022, Enums.TypeProjectEnum.SCHOOL);

            Projects.Add(pEcoBasket);
            #endregion

            #region EvolutionGame
            ProjectModel pEvolGame = new ProjectModel("Evolution Game", "",
                "Python, Tkinter", null, null, 1, 2021, Enums.TypeProjectEnum.PERSO);

            Projects.Add(pEvolGame);
            #endregion

            #region Mastermind
            ProjectModel pMastermind = new ProjectModel("Mastermind", "",
                "Python, Tkinter", null, null, 1, 2021, Enums.TypeProjectEnum.PERSO);

            Projects.Add(pMastermind);
            #endregion

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
