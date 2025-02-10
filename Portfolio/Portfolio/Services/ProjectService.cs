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
                "It's made with the framework Blazor, an ASP.NET Core framework. That framework allows to integrate C# in HTML files. I also used the library MudBlazor which proposes ready-to-use components.", 
                "Blazor", null, "https://github.com/abaivel/Portfolio", 1, 2025,"images/fond_portfolio.png", TypeProjectEnum.PERSO, TypeSoftwareEnum.WEBSITE));
            #endregion

            #region 4XGame
            ProjectModel p4XGame = new ProjectModel("4X Game", "This project is a 4X Game, which is a strategy game in which the users' actions can be summarized by the '4X', eXploration, eXpansion, eXploitation and eXtermination." +
                "The purpose of this project was to program a simple game using JEE, with servlets, JSPs and JPA and by respecting a MVC architecture.",
                "Java, JEE, JPA, Servlet, JSP", null, "https://github.com/abaivel/Projet_JEE", 4, 2025, "images/fond_ecran_4xgame.jpeg", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WEBSITE);

            p4XGame.Paragraphes.Add("The website opens on a connexion page on which the user can enter their login and their password. The logins and passwords are saved in a database. " +
                "The user can access the game either by entering an unused login or by entering the right login and password. " +
                "Once they're in the game, they can start playing.");
            p4XGame.Images.Add("images/game4X_Connection_Page.png");

            p4XGame.Paragraphes.Add("The game takes place on a 10x10 grid with different types of squares:\n" +
                " - City: A player can own a city by winning a fight against it. Then it produces production points to the player, with which he can recruit new soldiers.\n" +
                " - Mountain: The soldiers cannot go on these squares.\n" +
                " - Forest: The soldiers can explore those squares to win production points.\n\n" +
                "The player can do one action by soldier each turn. The possible actions are:\n" +
                " - Move right, left, up or down\n" +
                " - Explore the square if it's a forest\n" +
                " - hHal himself\n" +
                " - Do nothing\n");
            p4XGame.Images.Add("images/game4X_Game_Page.png");

            p4XGame.Paragraphes.Add("If a soldier runs into a city or an enemy soldier, a fight starts. The fight works with random values. If a soldier loses all his life points, he dies and disappears from the grid. If a city loses all its points, the player now owns the city.");
            p4XGame.Images.Add("images/game4X_Fight_Page.png");

            p4XGame.Paragraphes.Add("\nOnly a few information like the games dates, the players' login, password and past scores are saved in a database. " +
                "The rest of the game information is saved directly on the server. To do that, we use the principle of the design pattern Singleton.");
            p4XGame.Images.Add(null);

            Projects.Add(p4XGame);
            #endregion

            #region Hedgeshop
            ProjectModel pHedgeShop = new ProjectModel("HedgeShop", "This project is an e-commerce website. We had to choose the objects to sell and one of my teammate adores hedgehogs so we did a website to sell objects for hedgehogs.\n\n",
                "Javascript, React.js, Python, Django", null, "https://github.com/UnderSkyle/ProjetWebING1", 3, 2024, "images/logo_hedgeshop.png", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WEBSITE);
            pHedgeShop.FigmaUrl = "https://www.figma.com/design/6SO6Ls87wV9MyICEIMrNNU/Dev-Web";
            
            pHedgeShop.Paragraphes.Add("The website opens on a home page presenting the website. It looks like a typical e-commerce website, with a home page, product pages, a account page and a cart page. " +
                "There are 3 kinds of product, \"Nourriture\" (\"Food\"), \"Cabane\" (\"Shed\"), \"Jouets\" (\"Toys\"). We also had to add a strange contact page. Those pages are also accessible from the footer, with the link to the social media of the website\n\n" +
                "The two other buttons in the top right corner are to access the cart and to connect (or to access the profile).\n\n" +
                "I did most of the frontend including the mock-up on Figma, the design of the logos and the color palette. I used the framework React.js to do the pages of the website and everything is responsive.");
            pHedgeShop.Images.Add("images/hedgeshop_home_page.png");

            pHedgeShop.Paragraphes.Add("Each product page looks like that. The list of products, their name, reference number, price and stock amounts are saved in a SQLite database. This database is managed with Django, a Python framework.\n\n" +
                "The user can click on the button to change the amount they want. If the amount is at least 1, the button to add to the cart appears. The user can see the amount of product left in stock by clicking on the button in the top right corner.");
            pHedgeShop.Images.Add("images/hedgeshop_products_page.png");

            pHedgeShop.Paragraphes.Add("The user doesn't have to be connected to add products to the cart, but it's mandatory to place an order. The user information is saved in the database in the Django's user table to have a more secure connection process.\n\n" +
                "Once the user is connected, he stays connected until he disconnects. In his profile, he can see his personal information, his shipping addresses and his past orders.");
            pHedgeShop.Images.Add("images/hedgeshop_connection_page.png");

            pHedgeShop.Paragraphes.Add("When the user adds a product to his cart, the number above the cart icon increases.\n\n" +
                " In the cart page, the user can place an order by choosing a shipping address. As it's a simple school project, no payment process is implemented.");
            pHedgeShop.Images.Add("images/hedgeshop_cart_page.png");

            Projects.Add(pHedgeShop);
            #endregion

            #region Level1
            ProjectModel pLevel1 = new ProjectModel("Level 1", "The purpose of that project was to program the first level of a video game in Java. " +
                "In the game, the player can control a character (a penguin) in a world where he can fight monsters, interact with non-playable characters (NPC), find and use items.",
                "Java, JavaFX", null, "https://github.com/abaivel/projet_javafx", 2, 2024, "images/image_level1.png", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WINDOWS_APP);
            pLevel1.Paragraphes.Add("The level is composed of three maps, accessible by different doors. The player can move his character (the penguin) with the keyboard arrows.\n" +
                "There are different kinds of squares :\n" +
                "- Grass (in green) : The character can move on it\n" +
                "- River (in blue) : The character will die if he goes into it without a buoy\n" +
                "- Wall (in brown) : The character cannot go on it\n" +
                "- Hedge (in dark green) : The character cannot go on it but it can jump over it\n" +
                "- Tree : The character cannot go on it");
            pLevel1.Images.Add("images/level1_grille_game.png");

            pLevel1.Paragraphes.Add("On the grid, the character can also find items like a buoy, a potion, a key (to open the door), a sword, etc..." +
                "Once he finds one, he can save it in his inventory. He can also find money and life points.");
            pLevel1.Images.Add(null);

            pLevel1.Paragraphes.Add("On the grid, there are 3 kinds of monsters : Wolves, Slimes and Looters. " +
                "If the character comes close to a monster, a combat starts. Both fighters can use potions, can dodge and can attack. Each kind of monster has its particular attack. For example, the slimes can poison the other fighter.\n\n" +
                "The fight stops when one of the fighters dies. If it's the player's character, the game is over. If it's the monster, it drops its items before dying and the character can get them.");
            pLevel1.Images.Add("images/level1_combat_page.png");

            pLevel1.Paragraphes.Add("There is also the NPCs (Non-playable character). There are 3 kinds : Merchants, Fouras (it's a reference to a french TV show but it means a wizard who asks enigmas) and Useless Persons. " +
                "The Useless Persons are indeed useless and just say random sentences. The Fouras ask enigmas and give money if the player answers correctly. The merchants can do more actions. " +
                "Indeed, the player can:\n" +
                " - Sell some of his items to the merchant\n" +
                " - Buy some items from the merchant\n" +
                " - Swap one of his items with one from the merchant");
            pLevel1.Images.Add("images/level1_dialog_merchant.png");

            Projects.Add(pLevel1);
            #endregion

            #region LBAPropreteWebsite
            ProjectModel pLBAWeb = new ProjectModel("LBA Proprete Website", "This is a website I programmed for my father's company. Indeed, my father has a cleaning company and he needed a website to manage his cleaning missions. He still isn't using it as he only has a few missions per week and doesn't have any employees.\n\n" +
                "As it was one of my first websites, the code is pretty basic and use only HTML, CSS and PHP. I had to learn how to use OVH, Filezilla and PHPMyAdmin to be able to host this website.",
                "HTML, CSS, PHP", "https://baivel.com/", null, 1, 2023, "images/image_lba_proprete.png", TypeProjectEnum.WORK, TypeSoftwareEnum.WEBSITE);

            pLBAWeb.Paragraphes.Add("The website opens on a connection page. It's not possible to create an account from here, only the admin accounts can create accounts for other people.\n\n " +
                "The logins and the encrypted passwords are saved in a database. The connection process is not very secure because I had no knowledge about security back then, but I am planning on redoing this website correctly in the future.");
            pLBAWeb.Images.Add("images/LBAProprete_connexion.png");

            pLBAWeb.Paragraphes.Add("The website has 5 main pages. Two of them, \"Collaborateurs\" (\"Collaborators\") and \"Missions\", have the same purpose, which is showing the missions. The difference is the sorting. " +
                "On the collaborators page, the list is sorted by collaborators and on the missions page, the list is sorted by missions (not very visible on the image as I have only 1 mission and 1 collaborator). On both pages, the user can filter the list by date and by collaborator/address (depending on the page).");
            pLBAWeb.Images.Add("images/LBAProprete_collaborateurs.png");

            pLBAWeb.Paragraphes.Add("On both those pages, a part of the tables are empty. Indeed, it's supposed to be filled with the data from a mobile app similar to the one I already did. That mobile app would fill the table with the time and place of the employees when they start the mission. That application is not programmed yet, but it's one of my future project.");
            pLBAWeb.Images.Add(null);

            pLBAWeb.Paragraphes.Add("The page \"Affectations\" is made to create the missions. To add one, the user chooses an address, a day of the week, a start time, an end time of the missions. The user also chooses the start date and the end date of the contract with this client. To finish, the user chooses the collaborator who is going to do those missions.\n\n" +
                "Once the affectation is created, the missions are generated automatically and are visible on the collaborators and missions pages. The end date of an affection can be modified and the list of missions will also be updated.\n\n" +
                "The user can also filter the affectations by collaborator and by address.");
            pLBAWeb.Images.Add("images/LBAProprete_affectations.png");

            pLBAWeb.Paragraphes.Add("The page \"Paramètrages\" (\"Settings\") allows the users to manage their collaborators and their addresses. The admin accounts can also manage the manager's accounts from this page. We decided to implement that idea of manager's accounts with the idea of a bigger company, with not only one person managing the employees. When a user creates a manager's account, he receives a email with the generated password for that account. The user can send it to the owner of this account to allow him to connect to the website.");
            pLBAWeb.Images.Add("images/LBAProprete_parametrages.png");


            Projects.Add(pLBAWeb);
            #endregion

            #region LBAPropreteAndroidApp
            ProjectModel pLBAAndroid = new ProjectModel("LBA Proprete Android App", "This is a Android application that I programmed for my father's company, like the preceding project. He wanted his future employees to be able to declare the beginning and the end of a mission on a mobile app.",
                "Java, Kotlin", null, "https://github.com/abaivel/Mission2Clean", 1, 2022, "images/image_lba_proprete.png", TypeProjectEnum.WORK, TypeSoftwareEnum.ANDROID_APP);

            pLBAAndroid.Paragraphes.Add("The application starts on a connexion page. Nothing is saved in a database, it's just to know who is declaring the mission. The information entered on this page is saved with the API SharedPreferences.\n\n" +
                "Once connected, the user arrives on a page with 3 big buttons, one to declare the beginning of a cleaning mission, one to declare its end and one to declare a missing cleaning product.\n" +
                "When the user clicks on one of those buttons, an email is sent to my father indicating the name of the employee and his location. To have access to his location, I had to deal with the phone authorization.");
            pLBAAndroid.Images.Add(null);

            pLBAAndroid.Paragraphes.Add(null);
            pLBAAndroid.Images.Add("images/Mission2Clean.png");

            Projects.Add(pLBAAndroid);
            #endregion

            /*
            #region Jeunes64
            ProjectModel pJeunes64 = new ProjectModel("Jeunes 6.4", "This is a website to help young people to have references when searching for a job.",
                "HTML, CSS, PHP", "http://www.baivel.com/jeunes64/page_accueil.html", "https://github.com/max91p/projet_Jeunes_6.4", 4, 2023, "images/image_jeunes64.png", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WEBSITE);

            Projects.Add(pJeunes64);
            #endregion
            
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
