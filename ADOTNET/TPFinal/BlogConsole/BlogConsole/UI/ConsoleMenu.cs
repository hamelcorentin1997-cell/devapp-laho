using TPFinal.Class;
using TPFinal.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace TPFinal.UI
{
    public class ConsoleMenu
    {
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("=== BLOG CONSOLE === \n 1. Lister les articles  \n 2. Creer un article \n 3. Voir un article \n 4. Modifier un article \n 5. Supprimer un article \n 6. Ajouter un commentaire \n 7. Supprimer un commentaire  \n 0. Quitter \n votre choix: ");

                string query = Console.ReadLine();
                switch (query)
                {
                    case "1":
                        //lister article
                        ArticleService.SeeAllArticle();
                        break;

                    case "2":
                        //creer article
                        Console.WriteLine("titre:");
                        string title = Console.ReadLine();

                        Console.WriteLine("Contenu de la note:");
                        string content = Console.ReadLine();

                        var creationDate = DateOnly.FromDateTime(DateTime.Now);
                        ArticleService.CreateArticle(title, content, creationDate);
                        break;

                    case "3":
                        //voir article
                        Console.WriteLine("id de l'article a consulter: ");
                        int id = int.Parse(Console.ReadLine());
                        ArticleService.SeeArticleById(id);
                        break;

                    case "4":
                        // Création de l'article à modifier
                        Console.WriteLine("ID de l'article à modifier: ");
                        int articleIdToModify = int.Parse(Console.ReadLine());

                        // Création du nouvel article avec le MÊME ID
                        Console.WriteLine("Nouveau titre:");
                         title = Console.ReadLine();

                        Console.WriteLine("Nouveau contenu:");
                         content = Console.ReadLine();

                        var modifDate = DateOnly.FromDateTime(DateTime.Now);

                        // Créer le nouvel article avec le même ID que l'article original
                        Article newArticle = new Article( title, articleIdToModify, content,   modifDate);
                        Console.WriteLine(ArticleService.ModifyArticle(articleIdToModify, newArticle));
                        break;

                    case "5":

                        //supprimer article
                        Console.WriteLine("id de l'article a suprimer: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        Console.WriteLine(ArticleService.DeleteArticle(deleteId));
                        break;

                    case "6":
                        //ajouter commentaire

                        Console.WriteLine("id de l'article à commenter: ");
                        int articleId = int.Parse(Console.ReadLine());
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
                        break;

                    case "7":
                        //supprimer commentaire
                        Console.WriteLine("merci de renseigner l'id du commentaire a supprimer.");
                         id = int.Parse(Console.ReadLine());
                        Console.WriteLine(CommentService.DeleteComment(id));
                        break;

                    case "0":
                        //quitter
                        Console.WriteLine("Au revoir!");
                        return;

                    default:
                        //si erreur dans la commande
                        Console.WriteLine("non reconnu! ");
                        break;

                }
            }








        }
    }
}
