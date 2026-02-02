using BlogConsole.UI;
using System.Runtime.CompilerServices;
using TPFinal.Class;
using TPFinal.Services;
using TPFinal.UI;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace TPFinal.UI
{
    public class ConsoleMenu
    {
        public static void Menu()
        {
            while (true)
            {
                ConsoleHelper.printHeader("MENU PRINCIPAL");
                Console.Write( " 1. Lister les articles  \n 2. Creer un article \n 3. Voir un article \n 4. Modifier un article \n 5. Supprimer un article \n 6. Ajouter un commentaire \n 7. Supprimer un commentaire  \n 0. Quitter \n votre choix: ");

                string query = Console.ReadLine();
                switch (query)
                {
                    case "1":
                        //lister article
                        ConsoleHelper.printHeader("LISTE DES ARTICLES");
                        ArticleService.SeeAllArticle();
                        ConsoleHelper.pause();
                        break;
                        
                    case "2":
                        //creer article
                        ConsoleHelper.printHeader("CREATION D'UN ARTICLE");
                        Console.WriteLine("titre:");
                        string title = Console.ReadLine();

                        Console.WriteLine("Contenu de la note:");
                        string content = Console.ReadLine();

                        var creationDate = DateOnly.FromDateTime(DateTime.Now);
                        ArticleService.CreateArticle(title, content, creationDate);
                        ConsoleHelper.pause();
                        break;

                    case "3":
                        //voir article
                        ConsoleHelper.printHeader("CONSULTATION D'UN ARTICLE");
                        Console.WriteLine("id de l'article a consulter: ");
                        int id;
                        while(int.TryParse(Console.ReadLine(), out id))
                            {                             
                            if (id >= 0) 
                            {
                                break;
                            }
                            else 
                            {
                                ConsoleHelper.errorMessage("l'id doit etre un entier non négatif! ");
                                Console.WriteLine();
                            }
                        }
                        ArticleService.SeeArticleById(id);
                        
                        ConsoleHelper.pause();
                        break;

                    case "4":
                        // Création de l'article à modifier
                        ConsoleHelper.printHeader("MODIFICATION D'UN ARTICLE");

                        Console.WriteLine("ID de l'article à modifier: ");
                        int articleIdToModify;
                        while(int.TryParse(Console.ReadLine(), out articleIdToModify))
                        {                             
                            articleIdToModify = int.Parse(Console.ReadLine());
                            if (articleIdToModify >= 0) 
                            {
                                break;
                            }
                            else 
                            {
                                ConsoleHelper.errorMessage("l'id doit etre un entier non négatif! ");
                                Console.WriteLine();
                            }
                        }


                        // Création du nouvel article avec le MÊME ID
                        Console.WriteLine("Nouveau titre:");
                         title = Console.ReadLine();

                        Console.WriteLine("Nouveau contenu:");
                         content = Console.ReadLine();

                        var modifDate = DateOnly.FromDateTime(DateTime.Now);

                        // Créer le nouvel article avec le même ID que l'article original
                        Article newArticle = new Article( title, articleIdToModify, content,   modifDate);
                        Console.WriteLine(ArticleService.ModifyArticle(articleIdToModify, newArticle));
                        ConsoleHelper.pause();
                        break;

                    case "5":

                        //supprimer article
                        ConsoleHelper.printHeader("SUPPRESSION D'UN ARTICLE");

                        Console.WriteLine("id de l'article a suprimer: ");

                        int deleteId;
                        while(int.TryParse(Console.ReadLine(), out deleteId))
                        {                             
                            if (deleteId >= 0) 
                            {
                                break;
                            }
                            else 
                            {
                                ConsoleHelper.errorMessage("l'id doit etre un entier non négatif! ");
                                Console.WriteLine();
                            }
                        }
                        ;
                        Console.WriteLine(ArticleService.DeleteArticle(deleteId));
                        ConsoleHelper.pause();
                        break;

                    case "6":

                        //ajouter commentaire
                        ConsoleHelper.printHeader("AJOUT D'UN COMMENTAIRE");
                        Console.WriteLine("id de l'article à commenter: ");
                        int articleId;
                        while (int.TryParse(Console.ReadLine(), out  articleId)) 
                        {
                            if (articleId >= 0) 
                            {
                                break;
                            }
                            else 
                            {
                                ConsoleHelper.errorMessage("l'id doit etre un entier non négatif! ");
                                Console.WriteLine();
                            }
                        };
                        Console.WriteLine("auteur du commentaire: ");
                        string? author = Console.ReadLine();
                        Console.WriteLine("contenu du commentaire: ");
                        content = Console.ReadLine();
                        var date = DateOnly.FromDateTime(DateTime.Now);
                        if (author != "") 
                        {
                            Comment comment = new Comment(articleId, author, content, date);
                            Console.WriteLine(CommentService.AddCommentary(comment));
                        }
                        else 
                        {
                            Comment comment = new Comment(articleId, content, date);
                            Console.WriteLine(CommentService.AddCommentary(comment));
                        }
                        ConsoleHelper.pause();
                        break;

                    case "7":
                        //supprimer commentaire
                        ConsoleHelper.printHeader("SUPPRESSION D'UN COMMENTAIRE");
                        Console.WriteLine("merci de renseigner l'id du commentaire a supprimer.");
                        while(int.TryParse(Console.ReadLine(), out id))
                        {                             
                            if (id >= 0) 
                            {
                                break;
                            }
                            else if (id == null)
                                {
                                ConsoleHelper.errorMessage("l'id ne peut pas etre vide! ");
                                Console.WriteLine();
                            }
                            else
                            {
                                ConsoleHelper.errorMessage("l'id doit etre un entier non négatif! ");
                                Console.WriteLine();
                            }
                        }

                        Console.WriteLine(CommentService.DeleteComment(id));
                        ConsoleHelper.pause();
                        break;

                    case "0":
                        //quitter
                        Console.WriteLine("Au revoir!"); 
                        ConsoleHelper.pause();
                        return;

                    default:
                        //si erreur dans la commande
                        ConsoleHelper.errorMessage("Commande inconnue, veuillez reessayer.");
                        ConsoleHelper.pause();
                        break;

                }
            }








        }
    }
}
