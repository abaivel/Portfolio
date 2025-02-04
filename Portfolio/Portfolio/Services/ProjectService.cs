using Portfolio.Enums;
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
            Projects.Add(new ProjectModel("Portfolio", "My most recent project is this portfolio.\n\n" +
                "It's made with the framework Blazor, a ASP.NET Core framework. That framework allows to integrate C# in HTML files. I also use the library MudBlazor which propose ready-to-use components.", 
                "Blazor", null, "https://github.com/abaivel/Portfolio", 1, 2025,"images/fond_portfolio.png", TypeProjectEnum.PERSO, TypeSoftwareEnum.WEBSITE));
            #endregion

            #region 4XGame
            ProjectModel p4XGame = new ProjectModel("4X Game", "This project is a 4X Game, which is a strategy game in which the users' actions can be summarize by the '4X', eXploration, eXpansion, eXploitation et eXtermination." +
                "The purpose of this project was te program a simple game using JEE, with servlets, JSPs and JPA and by respecting a MVC architecture.",
                "Java, JEE, JPA, Servlet, JSP", null, "https://github.com/abaivel/Projet_JEE", 4, 2025, "images/fond_ecran_4xgame.jpeg", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WEBSITE);

            p4XGame.Paragraphes.Add("The website opens on a connexion page on which the user can enter their login and their password. The logins and passwords are saved in a database. " +
                "The user can access the game either by entering a unused login or by entering the right login and password." +
                "Once they're in the game, they can start playing.");
            p4XGame.Images.Add("images/game4X_Connection_Page.png");

            p4XGame.Paragraphes.Add("The game takes place on a 10x10 grid with different types of squares:\n" +
                " - City: A player can own a city by wining a fight against it. Then it produces production points to the player, with which he can recrute new soldiers.\n" +
                " - Montain: The soldiers cannot go on these squares.\n" +
                " - Forest: The soldiers can explore those square to win production points.\n\n" +
                "The player can do one action by soldier each turn. The possible actions are:\n" +
                " - Move right, left, up or down\n" +
                " - Explore the square if it's a forest\n" +
                " - heal himself\n" +
                " - do nothing\n");
            p4XGame.Images.Add("images/game4X_Game_Page.png");

            p4XGame.Paragraphes.Add("If a soldier runs into a city or a enemy soldier, a fight start. The fights works with randoms values. If a soldier loses all his life points, he dies and disappears from the grid. If a city loses all its points, the player now owns the city.");
            p4XGame.Images.Add("images/game4X_Fight_Page.png");

            p4XGame.Paragraphes.Add("\nOnly a few informations like the games dates, the players' login, password and past scores are saved in a database. " +
                "The rest of the game informations are saved directly on the server. To do that, we use the principle of the design pattern Singleton.");
            p4XGame.Images.Add(null);

            Projects.Add(p4XGame);
            #endregion

            #region Hedgeshop
            ProjectModel pHedgeShop = new ProjectModel("HedgeShop", "This project is a sales website. We had to choose the objects to sell and one of my teammate adores hedgehog so we did a website to sell objects for hedgehogs.\n\n",
                "Javascript, React.js, Python, Django", null, "https://github.com/UnderSkyle/ProjetWebING1", 3, 2024, "images/logo_hedgeshop.png", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WEBSITE);

            pHedgeShop.Paragraphes.Add("The website opens on a home page presenting the website. The website has the typical page of a e-commerce website. " +
                "There are 3 kinds of product, \"Nourriture\" (\"Food\"), \"Cabane\" (\"Shed\"), \"Jouets\" (\"Toys\"). We also had to add a strange contact page. Those pages are also accessible from the footer, with the link to the social media of the website\n\n" +
                "The two other buttons in the top right corner are to access the cart and to connect (or to access the profile).\n\n" +
                "I did most of the frontend including the design of the logos and the color palette. I used the framework React.js to do the pages of the website and everything is responsive.");
            pHedgeShop.Images.Add("images/hedgeshop_home_page.png");

            pHedgeShop.Paragraphes.Add("Each product page look like that. The list of products, their name, reference number, price and stock amounts are saved in a SQLite database. This database is managed thanks to Django, a Python framework.\n\n" +
                "The user can click on the button to change the amount they want. If the amount is at least 1, the button to add to the cart appears. The user can see the amount of product left in stock by clicking the button in the top right corner.");
            pHedgeShop.Images.Add("images/hedgeshop_products_page.png");

            pHedgeShop.Paragraphes.Add("The user don't have to be connected to add products to the cart but it's mandatory to place an order. The user information are saved in the database in the Django's user table to have a more secure connection process.\n\n" +
                "Once the user is connected, he stays connected until he deconnects. In his profile, he can see his personnal informations, his shipping addresses and his past orders.");
            pHedgeShop.Images.Add("images/hedgeshop_connection_page.png");

            pHedgeShop.Paragraphes.Add("When the user add a product to his cart, the number above the cart icon increases.\n\n" +
                " In the cart page, the user can place an order by choosing a shipping address. As it's a simple school project, no paiement process is implemented.");
            pHedgeShop.Images.Add("images/hedgeshop_cart_page.png");

            Projects.Add(pHedgeShop);
            #endregion

            #region Level1
            ProjectModel pLevel1 = new ProjectModel("Level 1", "The purpose of that project was to program the first level of a video game in Java. " +
                "In the game, the player can control a character (a penguin) in a world where he can fight monters, interact with non-playable characters (NPC), find and use items.",
                "Java, javafx", null, "https://github.com/abaivel/projet_javafx", 2, 2024, "images/image_level1.png", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WINDOWS_APP);
            pLevel1.Paragraphes.Add("The level is composed of three maps, accessible by different doors. The player can move his character (the penguin) with the keyboard arrows.\n" +
                "There are different kinds of squares :\n" +
                "- Grass (in a green) : The character can move on it\n" +
                "- River (in blue) : The character will die if he go on it without a buoy\n" +
                "- Wall (in brown) : The character cannot go on it\n" +
                "- Hedge (in dark green) : The character cannot go on it but it can jump over it\n" +
                "- Tree : The character cannot go on it");
            pLevel1.Images.Add("images/level1_grille_game.png");

            pLevel1.Paragraphes.Add("On the grid, the character can also find items like a buoy, a potion, a key (to open the door), a sword, etc..." +
                "Once he find it, he can saved in his inventory. He can also find money and life points.");
            pLevel1.Images.Add(null);

            pLevel1.Paragraphes.Add("On the grid, there is 3 kinds of monsters : Wolves, Slimes and Looters." +
                "If the character comes close to a monster, a combat starts. Both fighters can use potions, can dodge and can attack. Each kind of monster has its particular attack. For example, the slimes poisoned the other fighter.\n\n" +
                "The fight stops when one of the fighter dies. If its the player's character, the game is over. If it's the monster, he drops his items before dying and the character can get them.");
            pLevel1.Images.Add("images/level1_combat_page.png");

            pLevel1.Paragraphes.Add("There is also the NPCs (Non-playable character). There are 3 kinds : Merchants, Fouras (it's a reference to a french TV show but it mean a wizard who asks egnimas) and Useless Persons. " +
                "The Useless Persons are indeed useless and just says randoms sentences. The Fouras ask enigmas and give money if the player answers correctly. The merchants can do more actions." +
                "The player can :\n" +
                " - sell some of his items to the merchant\n" +
                " - buy some items from the merchant\n" +
                " - swap one of his item with one from the merchant");
            pLevel1.Images.Add("images/level1_dialog_merchant.png");

            Projects.Add(pLevel1);
            #endregion

            #region LBAPropreteWebsite
            ProjectModel pLBAWeb = new ProjectModel("LBA Proprete Website", "",
                "HTML, CSS, PHP", "https://baivel.com/", null, 1, 2023, "images/image_lba_proprete.png", TypeProjectEnum.WORK, TypeSoftwareEnum.WEBSITE);

            Projects.Add(pLBAWeb);
            #endregion

            #region LBAPropreteAndroidApp
            ProjectModel pLBAAndroid = new ProjectModel("LBA Proprete Android App", "",
                "Java, Kotlin", null, null, 1, 2022, "images/image_lba_proprete.png", TypeProjectEnum.WORK, TypeSoftwareEnum.ANDROID_APP);

            Projects.Add(pLBAAndroid);
            #endregion

            #region Jeunes64
            ProjectModel pJeunes64 = new ProjectModel("Jeunes 6.4", "",
                "HTML, CSS, PHP", "http://www.baivel.com/jeunes64/page_accueil.html", "https://github.com/max91p/projet_Jeunes_6.4", 4, 2023, "images/image_jeunes64.png", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WEBSITE);

            Projects.Add(pJeunes64);
            #endregion
            /*
            #region CYmeteo
            ProjectModel pCYMeteo = new ProjectModel("CY meteo", "",
                "C, Shell", null, "https://github.com/abaivel/projet_meteo", 1, 2023, TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WINDOWS_APP);

            Projects.Add(pCYMeteo);
            #endregion

            #region Tetris
            ProjectModel pTetris = new ProjectModel("Tetris", "",
                "C", null, "https://github.com/abaivel/projet_tetris", 1, 2022, TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WINDOWS_APP);

            Projects.Add(pTetris);
            #endregion

            #region Bujo
            ProjectModel pBujo = new ProjectModel("Bujo", "",
                "Java, Kotlin", null, null, 1, 2022, TypeProjectEnum.PERSO, TypeSoftwareEnum.ANDROID_APP);

            Projects.Add(pBujo);
            #endregion

            #region EcoBasket
            ProjectModel pEcoBasket = new ProjectModel("Eco-Basket", "",
                "Kotlin", null, null, 1, 2022, TypeProjectEnum.SCHOOL, TypeSoftwareEnum.ANDROID_APP);

            Projects.Add(pEcoBasket);
            #endregion

            #region EvolutionGame
            ProjectModel pEvolGame = new ProjectModel("Evolution Game", "",
                "Python, Tkinter", null, null, 1, 2021, TypeProjectEnum.PERSO, TypeSoftwareEnum.WINDOWS_APP);

            Projects.Add(pEvolGame);
            #endregion

            #region Mastermind
            ProjectModel pMastermind = new ProjectModel("Mastermind", "",
                "Python, Tkinter", null, null, 1, 2021, TypeProjectEnum.PERSO, TypeSoftwareEnum.WINDOWS_APP);

            Projects.Add(pMastermind);
            #endregion
            */

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
