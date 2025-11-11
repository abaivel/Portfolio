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
            /*#region Site de formations de CYJE
            Projects.Add(new ProjectModel("Site de formations de CYJE", "",
                "Wordpress", "https://www.formation.cyje.fr/", null, 2, 2025, "images/logo_cyje.png", TypeProjectEnum.JUNIOR_ENTREPRISE, TypeSoftwareEnum.WEBSITE));
            #endregion
            #region Site vitrine de CYJE
            Projects.Add(new ProjectModel("Site vitrine de CYJE", "",
                "Wordpress", "https://www.cyje.fr/", null, 1, 2025, "images/logo_cyje.png", TypeProjectEnum.JUNIOR_ENTREPRISE, TypeSoftwareEnum.WEBSITE));
            #endregion
            #region CYJEQRCodes
            Projects.Add(new ProjectModel("CYJEQRCodes", "",
                "React, Django", "https://marketing.cyje.fr/", null, 1, 2025, "images/cyjeqrcode_accueil.png", TypeProjectEnum.JUNIOR_ENTREPRISE, TypeSoftwareEnum.WEBSITE));
            #endregion*/

            #region Portfolio
            Projects.Add(new ProjectModel("Portfolio", "Ce portfolio a été réalisé avec le framework Blazor qui est un framework ASP.NET Core qui permet d'utiliser du C# dans des fichiers HTML. " +
                "J'ai aussi utilisé la bibliothèque MudBlazor qui propose des composants utilisables.",
                "Blazor", null, "https://github.com/abaivel/Portfolio", 1, 2025, "images/fond_portfolio.png", TypeProjectEnum.PERSO, TypeSoftwareEnum.WEBSITE));
            #endregion

            #region 4XGame
            ProjectModel p4XGame = new ProjectModel("4X Game", "Ce projet est un jeu 4X, c'est à dire un jeu de stratégie dans lequel les actions du joueur peuvent être résumées par les \"4X\", eXploration, eXpansion, eXploitation et eXtermination." +
                "L'objectif de ce projet était de programmer un jeu simple en utilisateur JEE avec des servlets, les JSPs et JPA et en respectant l'architecture MVC.",
                "Java, JEE, JPA, Servlet, JSP", null, "https://github.com/abaivel/Projet_JEE", 4, 2025, "images/fond_ecran_4xgame.jpeg", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WEBSITE);


            p4XGame.Paragraphes.Add("Le site web s'ouvre sur une page de connexion sur laquelle l'utilisateur peut entrer son identifiant et son mot de passe. Les identifiants et les mots de passe sont sauvegardés dans une base de données." +
                "L'utilisateur peut accéder le jeu soit en entrant un identifiant non utilisé, soit en entrant le bon identifiant et le bon mot de passe." +
                "Une fois qu'il s'est connecté, le joueur peut commencer à jouer.");
            p4XGame.Images.Add("images/game4X_Connection_Page.png");

            p4XGame.Paragraphes.Add("Le jeu se déroule sur une grille 10x10 avec différents types de cases :\n" +
                " - Ville: Un joueur peut posséder une ville en gagnant un combat contre elle. La ville produit ensuite des points de production au joueur avec lesquels il peut recruter de nouveaux soldats.\n" +
                " - Montagne: Les soldats ne peuvent pas aller sur ces cases\n" +
                " - Forêt: Les soldats peuvent explorer ces cases pour gagner des points de production\n\n" +
                "Le joueur peut faire qu'une seule action par soldat par tour. Les actions possibles sont :\n" +
                " - Se déclacer vers le haut, le bas, la droite et la gauche\n" +
                " - Explorer la case si c'est une forêt\n" +
                " - Se soigner\n" +
                " - Ne rien faire\n");
            p4XGame.Images.Add("images/game4X_Game_Page.png");

            p4XGame.Paragraphes.Add("Si un soldat croise une ville ou un ennemi, un combat commence." +
                "Le combat fonctionne avec des valeurs aléatoires, rien n'est controllé par le joueur." +
                "Si un soldat perd tous ses points de vie, il meurt et disparait de la grille." +
                "Si une ville perd tous ses points de vie, le joueur possède maintenant la ville.\n");
            p4XGame.Images.Add("images/game4X_Fight_Page.png");

            p4XGame.Paragraphes.Add("Seulement les dates des parties, les identifiants, mots de passe et scores des joueurs sont sauvegardés dans une base de données." +
                "Le reste des informations du jeu sont sauvegardés directement sur le serveur. Pour réaliser cela, nous avons utilisé le design pattern Singleton.");
            p4XGame.Images.Add(null);

            Projects.Add(p4XGame);
            #endregion

            #region Hedgeshop

            ProjectModel pHedgeShop = new ProjectModel("HedgeShop", "Ce projet est un site de e-commerce. Le choix des objets à vendre était libre et une de mes coéquipières adore les hérissons donc nous avons fait un site de vente d'objets pour hérisson.\n\n",
                "Javascript, React.js, Python, Django", null, "https://github.com/UnderSkyle/ProjetWebING1", 3, 2024, "images/logo_hedgeshop.png", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WEBSITE);
            pHedgeShop.FigmaUrl = "https://www.figma.com/design/6SO6Ls87wV9MyICEIMrNNU/Dev-Web";

            pHedgeShop.Paragraphes.Add("Le site web s'ouvre sur une page d'accueil présentant le site web. Ce site ressemble à un site classique d'e-commerce, avec une page d'accueil, des pages par catégories de produits, une page de profil et une page de panier."+
                "Il y a trois types de produits, \"Nourriture\", \"Cabane\", \"Jouets\". Nous devions aussi ajouter une étrange page de contact. Toutes ces pages sont aussi accessibles depuis le footer, qui contient aussi les liens vers les réseaux sociaux du site web.\n\n" +
                "Les deux autres boutons dans le coin à droite servent à accéder au panier et à se connecter (ou à accéder à la page de profil).\n\n" +
                "J'ai réalisé une bonne partie du frontend dont la maquette sur Figma, le design des logos et la palette de couleurs. J'ai utilisé le frameword React pour réaliser les pages de ce site web and l'ensemble est responsive.");
            pHedgeShop.Images.Add("images/hedgeshop_home_page.png");

            pHedgeShop.Paragraphes.Add("Chaque page de produit ressemble à ça. La liste des produits, leur nom, numéro de référence, prix et stock sont sauvegardé dans une base de données SQLite. Cette base de données est géré par le framework Django.\n\n" +
                "L'utilisateur peut cliquer sur le bouton pour changer la quantité qu'il veut. Si la quantité est au moins de 1, le bouton pour ajouter au panier apparait. L'utilisateur peut voir la quantité de produits restant en stock en cliquant sur le bouton dans le coin en haut à droite.");
            pHedgeShop.Images.Add("images/hedgeshop_products_page.png");

            pHedgeShop.Paragraphes.Add("L'utilisateur n'a pas besoin d'être connecté pour ajouter des produits au panier mais c'est obligatoire pour passer la commande. Les informations de l'utilisateur sont enregistrés dans la base de données dans la table User de Django pour avoir un processus de connexion sécurisé.\n\n" +
                "Une fois l'utilisateur connecté, il reste connecté jusqu'à qu'il se déconnecte. Dans son profil, il peut voir ses informations, ses adresses de livraison et ses commandes.");
            pHedgeShop.Images.Add("images/hedgeshop_connection_page.png");


            pHedgeShop.Paragraphes.Add("Quand l'utilisateur ajoute un produit à son panier, le numéro au dessus de l'icone de caddie augmente.\n\n" +
                "Dans la page du panier, l'utilisateur peut passer une commande en choissisant l'adresse de livraison. Comment c'est un projet d'école, aucun processus de paiement a été implémenté.");
            pHedgeShop.Images.Add("images/hedgeshop_cart_page.png");

            Projects.Add(pHedgeShop);
            #endregion

            #region Level1
            
            ProjectModel pLevel1 = new ProjectModel("Level 1", "L'objectif de ce projet était de programmer le premier niveau d'un jeu vidéo en Java." +
                "Dans le jeu, le joueur peut controler un personnage (un pinguin) dans un monde où il peut combattre des monstres, interagir avec des personnages non jouables (PNJ), trouver et utiliser des objets.",
                "Java, JavaFX", null, "https://github.com/abaivel/projet_javafx", 2, 2024, "images/image_level1.png", TypeProjectEnum.SCHOOL, TypeSoftwareEnum.WINDOWS_APP);


            pLevel1.Paragraphes.Add("Le niveau est composé de 3 mondes, accessibles par différentes portes. Le joueur peut déplacer son personnage (le pinguin) avec les flèches de son clavier.\n" +
                "Il y a plusieurs types de cases\n" +
                "- Herbe (en vert) : Le personnage peut se déplacer dessus\n" +
                "- Rivière (en bleu) : Le personnage meurt si il va dessus sans bouée\n" +
                "- Mur (en marron) : Le personnage ne peut pas aller dessus\n" +
                "- Haie (en marron foncé) : Le personnage ne peut pas aller dessus mais peut sauter par dessus\n" +
                "- Arbre : Le personnage ne peut pas aller dessus");
            pLevel1.Images.Add("images/level1_grille_game.png");

            pLevel1.Paragraphes.Add("Sur la grille, le personnage peut trouver des objets comme une bouée, une potion, une clé (pour ouvrir les portes), une épée, etc..." +
                "Quand il trouve un objet, celui-ci est sauvegardé dans son inventaire. Il peut aussi trouver de l'argent et les points de vie.");
            pLevel1.Images.Add(null);

            pLevel1.Paragraphes.Add("Sur la grille, il y a 3 types de monstres : les loups, les slimes et les pilleurs." +
                "Si le personnage se déplace proche d'un monstre, un combat commence. Les deux combattants peuvent utiliser des potions, esquiver et attaquer. Chaque type de monstre a une attaque particulière. Par exemple, les slimes peuvent empoisonner l'autre combattant.\n\n" +
                "Le combat se termine lorsqu'un des combattants meurt. Si c'est le personnage du joueur, le jeu se termine. Si c'est le monstre, il lache ses objets sur la grillle avant de mourir et le personnage peut les récupérer.");
            pLevel1.Images.Add("images/level1_combat_page.png");

            pLevel1.Paragraphes.Add("Il y a aussi les personnages non jouables (PNJ). Il y a 3 types : Marchants, Fouras (comme le père Fouras) et les personnages inutiles." +
                "Les personnages inutiles sont effectivement inutiles et ne font que dire des phrases aléatoires. Les Fouras posent des énigmes et donnent de l'argent au personnage si le joueur répond correctement. " +
                "Les marchants peuvent faire plus d'actions. En effet, avec le marchant, le joueur peut :\n" +
                " - vendre certains de ses objets au marchant\n" +
                " - Acheter des objets du marchant\n" +
                " - Echanger un de ses objets pour un des objets du marchant");
            pLevel1.Images.Add("images/level1_dialog_merchant.png");

            Projects.Add(pLevel1);
            #endregion

            #region LBAPropreteWebsite

            ProjectModel pLBAWeb = new ProjectModel("Site web LBA Proprete", "C'est un site web que j'ai programmé pour l'entreprise de mon père, une entreprise de nettoyage pour les professionnels. Il avait besoin d'un site web pour pouvoir gérer ses missions de nettoyage. \n\n" +
                "Comme c'est un de mes premiers sites web, le code est assez basique et utilise seulement du HTML, CSS, Javascript et PHP. J'ai dû apprendre à utiliser OVH, Filezilla et PHPMyAdmin pour pouvoir héberger le site web.",
                "HTML, CSS, PHP", "https://baivel.com/", null, 1, 2023, "images/image_lba_proprete.png", TypeProjectEnum.WORK, TypeSoftwareEnum.WEBSITE);


            pLBAWeb.Paragraphes.Add("Le site web ouvre sur une page de connexion. Il n'est pas possible de créer un compte depuis cette page, seulement des administrateurs peuvent créer des comptes pour d'autres personnes.\n\n" +
                "Le nom d'utilisateur et le mot de passe chiffré sont stockés dans une base de données. Le processus de connexion n'est pas très sécurisé parce que mes connaissances à ce moment là étaient limités dans ce domaine mais une refactorisation de ce site est prévu prochainement.");
            pLBAWeb.Images.Add("images/LBAProprete_connexion.png");

            pLBAWeb.Paragraphes.Add("Le site web a 5 pages principales. 2 d'entre elles \"Collaborateurs\" et \"Missions\" ont le même objectif, celui de montrer les missions. La différence est la façon dont les missions sont triées." +
                "Sur la page \"Collaborateurs\", la liste est trié par collaborateur alors que sur la page \"Missions\", la liste est trié par mission (ce n'est pas très visible sur l'image comme il n'y a qu'une seule mission et un seul collaborateur). Sur les deux pages, l'utilisateur peut filtrer la liste par date et par collaborateur/adresse (selon la page).");
            pLBAWeb.Images.Add("images/LBAProprete_collaborateurs.png");

            pLBAWeb.Paragraphes.Add("Sur les deux pages, une partie du tableau est vide. En effet, cette partie est censé est remplie avec les données d'une application mobile similaire à celle que j'ai déjà faite. L'application remplirai le tableau avec l'heure et la localisation de l'employé quand il commence la mission. Cette application n'a pas encore été programmé mais c'est un de mes futurs projets.");
            pLBAWeb.Images.Add(null);

            pLBAWeb.Paragraphes.Add("La page \"Affectations\" sert à créer les missions. Pour en ajouter une, l'utilisateur choisit l'adresse, un jour de la semaine, une heure de début et une heure de fin des missions. L'utilisateur peut aussi choisir la date de début et de fin du contrat avec le client. Pour finir, l'utilisateur peut choisir le collaborateur qui va réaliser ces missions.\n\n" +
                "Une fois l'affectation créée, les missions sont généré automatiquement et sont visibles dans les pages \"Collaborateurs\" et \"Missions\". La date de fin de l'affectation peut être modifié et la liste des missions sera mise à jour.\n\n" +
                "L'utilisateur peut aussi filtrer les affectations par collaborateur et par adresse.");
            pLBAWeb.Images.Add("images/LBAProprete_affectations.png");

            pLBAWeb.Paragraphes.Add("La page \"Paramètrages\" permet à l'utilisateur de gérer ses collaborateurs et ses adresses." +
                "L'administrateur peut aussi gérer les comptes des managers depuis cette page." +
                "Nous avons décidé d'implémenter cette idée des comptes manager avec l'idée en tête que le site web pourrait être utilisé par une grosse entreprise, avec plus d'une personne gérant des employés." +
                "Quand l'utilisateur crée un compte manager, il reçoit un email avec le mot de passe généré pour le compte créé." +
                "L'utilisateur peut ensuite l'envoyer au propriétaire du compte créé pour qu'il puisse se connecter au site web.");
            pLBAWeb.Images.Add("images/LBAProprete_parametrages.png");


            Projects.Add(pLBAWeb);
            #endregion

            #region LBAPropreteAndroidApp
            ProjectModel pLBAAndroid = new ProjectModel("Application Android LBA Proprete", "Ceci est une application Android que j'ai programmé pour l'entreprise de mon père. Il voulait que ces futurs employés soient capables de déclarer le début et la fin de leur mission sur une application mobile.",
                "Java, Kotlin", null, "https://github.com/abaivel/Mission2Clean", 1, 2022, "images/image_lba_proprete.png", TypeProjectEnum.WORK, TypeSoftwareEnum.ANDROID_APP);

            pLBAAndroid.Paragraphes.Add("L'application commence avec une page de connexion. Rien n'est enregistré dans une base de données, c'est juste pour savoir qui déclare la mission. Les informations entrées sur cette page sont enregistrées avec l'API SharedPreferences.\n\n" +
                "Une fois connecté, l'utilisateur arrive sur une page avec 3 boutons, un pour déclarer le début de la mission de nettoyage, un pour déclarer la fin de la mission et un pour déclarer le manque d'un produit de nettoyage.\n" +
                "Quand l'utilisateur clique sur un des boutons, un email est envoyé à mon père indiquant le nom de l'employé and sa localisation. Pour avoir accès à se localisation, j'ai dû gérer les autorisations du téléphone.");
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
