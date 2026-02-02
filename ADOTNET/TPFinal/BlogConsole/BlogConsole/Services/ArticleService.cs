using System.Security.Cryptography.X509Certificates;
using TPFinal.Class;

namespace TPFinal.Services
{
    public class ArticleService
    {

        //lister article
        public static void SeeAllArticle()
        {
            foreach (Article article in Article.Articles)
            {
                Console.WriteLine(article);

            }
        }
        //creer article
        public static void CreateArticle(string title, string content, DateOnly creationDate)
        {
            Article article = new(title, content, creationDate);
            Article.Articles.Add(article);
        }
        //voir article
        public static void SeeArticleById(int id)
        {
            foreach (Article article in Article.Articles)
            {
                if (article.CurrentId == id)
                {
                    Console.WriteLine(article);
                    foreach(Comment comment in article.Comments)
                    {  Console.WriteLine(comment); }
                    return;

                }

            }
        }
        //modifier article
        public static string ModifyArticle(int id, Article newArticle)
        {
            int index = Article.Articles.FindIndex(a => a.CurrentId == id);

            if (index != -1)
            {
                newArticle.CreationDate = Article.Articles[index].CreationDate;
                Article.Articles[index] = newArticle;
                return "article moddifié avec succés";
            }
            else
            {
                return $"Article avec l'ID {id} non trouvé.";
            }
        }

        

        //supprimer article
        public static string DeleteArticle(int id)
        {
            int index = Article.Articles.FindIndex(a => a.CurrentId == id);
            if (index != -1)
            {
                Article.Articles.RemoveAt(index);
                return "article suprimmé";
            }
            else
            {
                return $"pas d'article trouvé pour l'id {id}";
            }


        }
    }
}
